using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AS1AChowdhury
{
    
    public partial class CarListingForm : Form
    {
        //List which contains the data from the Cars.xml file
        List<Car> filterSize = new List<Car>();
        List<Car> filterPrice = new List<Car>();
        List<Car> myCars = new List<Car>();
        List<Car> selectedCars = new List<Car>();

        public CarListingForm()
        {
            InitializeComponent();

            this.Text = "Assignment 1 - Car Listings";
            this.AutoScroll = true;

            //Calling function to read list of cars from Cars.xml file
            ReadListOfCars("Cars.xml");
            Console.ReadLine();

            InitializeDataGridViewAllCars();

            InitializeDataGridViewSelectedCars();

            InitializeListBoxMakes();
            InitiallizeListBoxYears();
            InitializeListBoxColors();
            InitializeListBoxDealers();

            InitialState();
            Reset();
            
            //Event handlers for buttons, checkboxes and textboxes, as they are modified by the user
            buttonResetFilters.Click += (s, e) => Reset();
            checkBoxPrice.CheckedChanged += PriceFilter;
            checkBoxSize.CheckedChanged += EngineFilter;
            textBoxPriceMax.TextChanged += PriceFilter;
            textBoxPriceMin.TextChanged += PriceFilter;
            textBoxSizeMax.TextChanged += EngineFilter;
            textBoxSizeMin.TextChanged += EngineFilter;
            dataGridViewSelectedCars.CellValueChanged += (s, e) => Reset();

        }

        /// <summary>
        /// Method used to clear all the selections and bring the application
        /// to its initial state
        /// </summary>
        private void Reset()
        {
            listBoxMakes.SelectedIndexChanged -= DisplayCars;
            listBoxYears.SelectedIndexChanged -= DisplayCars;
            listBoxColors.SelectedIndexChanged -= DisplayCars;
            listBoxDealers.SelectedIndexChanged -= DisplayCars;

            for (int i = 0; i < listBoxMakes.Items.Count; i++) {
                listBoxMakes.SetSelected(i, true);
            }
            for (int i = 0; i < listBoxYears.Items.Count; i++)
            {
                listBoxYears.SetSelected(i, true);
            }
            for (int i = 0; i < listBoxColors.Items.Count; i++)
            {
                listBoxColors.SetSelected(i, true);
            }
            for (int i = 0; i < listBoxDealers.Items.Count; i++)
            {
                listBoxDealers.SetSelected(i, true);
            }

            //Initializing Checkboxes
            checkBoxPrice.Checked = false;
            checkBoxSize.Checked = false;

            //Initializing TextBoxes
            textBoxPriceMin.Clear();
            textBoxPriceMax.Clear();
            textBoxSizeMin.Clear();
            textBoxSizeMax.Clear();

            DisplayCars();

            listBoxMakes.SelectedIndexChanged += DisplayCars;
            listBoxYears.SelectedIndexChanged += DisplayCars;
            listBoxColors.SelectedIndexChanged += DisplayCars;
            listBoxDealers.SelectedIndexChanged += DisplayCars;
        }

        /// <summary>
        /// Method to display cars in DataGridViewSelectedCars based on filters 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayCars(object sender = null, EventArgs e = null)
        {
            //Checking Filters
            dataGridViewSelectedCars.Rows.Clear();
            double maxPrice = 0;
            double minPrice = 0;
            decimal maxEngineSize = 0;
            decimal minEngineSize = 0;

            if (checkBoxPrice.Checked == true) {
                    double.TryParse(textBoxPriceMax.Text, out maxPrice);
                    double.TryParse(textBoxPriceMin.Text, out minPrice);
            }

            if (checkBoxSize.Checked == true) {
                    decimal.TryParse(textBoxSizeMax.Text, out maxEngineSize);
                    decimal.TryParse(textBoxSizeMin.Text, out minEngineSize);
            }

            List<string> selectedMakes = listBoxMakes.SelectedItems.OfType<string>().ToList();
            List<int> selectedYears = listBoxYears.SelectedItems.OfType<int>().ToList();
            List<string> selectedColors = listBoxColors.SelectedItems.OfType<string>().ToList();
            List<string> selectedDealers = listBoxDealers.SelectedItems.OfType<string>().ToList();
            selectedCars = myCars.Where(s => selectedMakes.Contains(s.Make)
                                        && selectedYears.Contains(s.Year)
                                        && selectedColors.Contains(s.Color)
                                        && selectedDealers.Contains(s.Dealer)).ToList();

            /*
            selectedCars1 = myCars.Where(s => selectedMakes.Contains(s.Make)
                                        && selectedYears.Contains(s.Year)
                                        && selectedColors.Contains(s.Color)
                                        && selectedDealers.Contains(s.Dealer)
                                        && CompareWithMaxMinPrice(s.Price, maxPrice,minPrice)
                                        && CompareWithMaxMinEngineSize(s.EngineSize, maxEngineSize,minEngineSize)).ToList();
*/
            Console.WriteLine(myCars.Count());

            labelCountSelectedCars.Text = selectedCars.Count().ToString();
            //dataGridViewSelectedCars.DataSource = selectedCars2.ToList();

            Console.WriteLine("Here"+selectedCars.Count());
            var totalPriceForSelectedCars = 0;
            var average = 0;
            foreach (Car eachCar in selectedCars) {
                dataGridViewSelectedCars.Rows.Add(
                    eachCar.Make,
                    eachCar.Year,
                    eachCar.Color,
                    eachCar.EngineSize,
                    String.Format("{0:C2}", eachCar.Price),
                    eachCar.Dealer);
                totalPriceForSelectedCars += eachCar.Price;
            }

            average = totalPriceForSelectedCars / selectedCars.Count();

            labelCountSelectedCars.Text = selectedCars.Count().ToString(); //Setting count label

            labelAveragePriceSelectedCars.Text = Convert.ToString(String.Format("{0:C}",average));

        }

        public bool CompareWithMaxMinPrice(double price, double maxPrice, double minPrice) {
            return (checkBoxPrice.Checked == true && price < maxPrice && price > minPrice) || checkBoxPrice.Checked == false;
        }

        public bool CompareWithMaxMinEngineSize(decimal engineSize, decimal maxEngineSize, decimal minEngineSize) {
            return (checkBoxSize.Checked == true && engineSize < maxEngineSize && engineSize > minEngineSize) || checkBoxSize.Checked == false;
        }

        /// <summary>
        /// Setting up ListBox for Dealers
        /// </summary>
        private void InitializeListBoxDealers()
        {
            listBoxDealers.Items.Clear();

            listBoxDealers.SelectionMode = SelectionMode.MultiExtended;

            listBoxDealers.DataSource = myCars
                .OrderBy(x => x.Dealer)
                .Select(x => x.Dealer)
                .Distinct()
                .ToList();
        }


        /// <summary>
        /// Setting up ListBox for Colors
        /// </summary>
        private void InitializeListBoxColors()
        {

            listBoxColors.Items.Clear();

            listBoxColors.SelectionMode = SelectionMode.MultiExtended;

            listBoxColors.DataSource = myCars
                .OrderBy(x => x.Color)
                .Select(x => x.Color)
                .Distinct()
                .ToList();

        }


        /// <summary>
        /// Setting up ListBox for Years
        /// </summary>
        private void InitiallizeListBoxYears()
        {
            
            listBoxYears.Items.Clear();

            listBoxYears.SelectionMode = SelectionMode.MultiExtended;

            listBoxYears.DataSource = myCars
                .OrderBy(x => x.Year)
                .Select(x => x.Year)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// Setting up ListBox for Makes
        /// </summary>
        private void InitializeListBoxMakes()
        {

            listBoxMakes.Items.Clear();

            listBoxMakes.SelectionMode = SelectionMode.MultiExtended;

            listBoxMakes.DataSource = myCars
                .OrderBy(x => x.Make)
                .Select(x => x.Make)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// InitialState method loads up the two DataGridView with all
        /// of the car information. 
        /// MIGHT REMOVE THIS FOR THE SECOND DATAGRID VIEW LATER AND LOAD IT UP BY FILTERING.
        /// </summary>
        private void InitialState()
        {

            //Displaying data into DataGridViewDataAllCars
            dataGridViewAllCars.Rows.Clear();

            var ascendingCarList = myCars.OrderBy(x => x.Make).ToList();
            var totalPriceForAllCars = 0;
            var average = 0;
            foreach (Car eachCar in ascendingCarList) {
                dataGridViewAllCars.Rows.Add(
                    eachCar.Make, 
                    eachCar.Year, 
                    eachCar.Color, 
                    eachCar.EngineSize, 
                    String.Format("{0:C2}",eachCar.Price), 
                    eachCar.Dealer);

                totalPriceForAllCars += eachCar.Price;
            }

            average = totalPriceForAllCars / ascendingCarList.Count();

            labelCountAllCars.Text = ascendingCarList.Count().ToString(); //Setting count label

            labelAveragePriceAllCars.Text = Convert.ToString(String.Format("{0:C}", average));

            dataGridViewSelectedCars.Rows.Clear();

            //Initializing Checkboxes
            checkBoxPrice.Checked = false;
            checkBoxSize.Checked = false;

            //Initializing TextBoxes
            textBoxPriceMin.Text = "";
            textBoxPriceMax.Text = "";
            textBoxSizeMin.Text = "";
            textBoxSizeMax.Text = "";

        }

        /// <summary>
        /// Setting up the DataGridView (to contain selected cars) Columns and other properties
        /// </summary>
        private void InitializeDataGridViewSelectedCars()
        {
            dataGridViewSelectedCars.Columns.Clear();
            dataGridViewSelectedCars.ReadOnly = true;
            dataGridViewSelectedCars.AllowUserToAddRows = false;
            dataGridViewSelectedCars.AllowUserToDeleteRows = false;
            dataGridViewSelectedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSelectedCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewSelectedCars.AutoSize = false;
            dataGridViewSelectedCars.RowHeadersVisible = false;
            dataGridViewSelectedCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewSelectedCars.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewSelectedCars.Columns.Clear();

            foreach (PropertyInfo eachCar in (new Car()).GetType().GetProperties())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn()
                {
                    Name = eachCar.Name,
                    ValueType = eachCar.GetType()
                };

                dataGridViewSelectedCars.Columns.Add(column);
            }
        }

        /// <summary>
        /// Setting up the DataGridView (to contain all cars) Columns and other properties
        /// </summary>
        private void InitializeDataGridViewAllCars()
        {
            // control should be readonly, nothing can be changed
            dataGridViewAllCars.Columns.Clear();
            dataGridViewAllCars.ReadOnly = true;
            dataGridViewAllCars.AllowUserToAddRows = false;
            dataGridViewAllCars.AllowUserToDeleteRows = false;
            dataGridViewAllCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAllCars.AutoSize = false;
            dataGridViewAllCars.RowHeadersVisible = false;
            dataGridViewAllCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewAllCars.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewAllCars.Columns.Clear();

            foreach (PropertyInfo eachCar in (new Car()).GetType().GetProperties())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn()
                {
                    Name = eachCar.Name,
                    ValueType = eachCar.GetType()
                };

                dataGridViewAllCars.Columns.Add(column);
            }
        }

        /// <summary>
        /// Reading List of Cars and it's attributes from the Cars.xml file
        /// </summary>
        /// <param name="fileName"></param>
        private void ReadListOfCars(string fileName)
        {
            //List<Car> myCars;  // list to be populated

            // open the file for reading
            OpenFileDialog openFileDialogCSV = new OpenFileDialog
            {
                
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                Filter = "XML files|*.xml"
            };
            StreamReader carsFile = new StreamReader(fileName);
            

            // open the filedialog, get a name, and open the file
            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                carsFile = File.OpenText(openFileDialogCSV.FileName);
            }
            // create the serializer, note use of typeof
            XmlSerializer carSerializer =
                new XmlSerializer(typeof(List<Car>), new XmlRootAttribute("ArrayOfCar"));   //NOTE TO SELF: MAKE SURE YOU HAVE THE RIGHT ROOT ATTRIBUTE! You were stuck here for 2 hours!

            // deserialize to the list of cars from file, note use of cast

            myCars = carSerializer.Deserialize(carsFile) as List<Car>;
            carsFile.Close();
            Console.WriteLine($"=> Reading list of cars from {fileName}");
            
            // display

            foreach (Car eachCar in myCars)
            {
                Console.WriteLine($"Make: {eachCar.Make}\nYear: {eachCar.Year}\nColor: {eachCar.Color}\nEngine Size: {eachCar.EngineSize}\nPrice: {eachCar.Price}\nDealer: {eachCar.Dealer}");
            }
        }


        /// <summary>
        /// Filters by Min and Max Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void PriceFilter(object sender = null, EventArgs eventArgs = null)
        {
            if (checkBoxPrice.Checked == true)
            {
                dataGridViewSelectedCars.Rows.Clear();
                int minimumPrice;
                int maximumPrice;
                bool minPriceParse = Int32.TryParse(textBoxPriceMin.Text, out minimumPrice);
                bool maxPriceParse = Int32.TryParse(textBoxPriceMax.Text, out maximumPrice);
                if (minPriceParse && maxPriceParse)
                {
                    filterPrice = selectedCars.Where(p => p.Price >= minimumPrice && p.Price <= maximumPrice).OrderBy(m => m.Make)
                    .ThenByDescending(y => y.Year)
                    .ThenBy(p => p.Price)
                    .ThenBy(c => c.Color)
                    .ToList().ToList();
                    if (filterPrice.Count() > 0)
                    {
                        foreach (var car in filterPrice)
                        {
                            dataGridViewSelectedCars.Rows.Add(car.Make, car.Year, car.Color, car.EngineSize, car.Price, car.Dealer);
                        }
                        labelCountSelectedCars.Text = filterPrice.Count().ToString();
                        labelAveragePriceSelectedCars.Text = filterPrice.Average(s => s.Price).ToString("n1");
                    }
                }
                else
                {
                    MessageBox.Show("Price is missing or not an integer");
                    labelCountSelectedCars.Text = "0";
                    labelAveragePriceSelectedCars.Text = "0"; 
                }
            }
            else
            {
                DisplayCars();
            }
        }

        /// <summary>
        /// Filter by Min and Max Engine Size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void EngineFilter(object sender = null, EventArgs eventArgs = null)
        {
            if (checkBoxSize.Checked == true)
            {
                dataGridViewSelectedCars.Rows.Clear();
                int minimumSize;
                int maximumSize;
                bool minSizeParse = Int32.TryParse(textBoxSizeMin.Text, out minimumSize);
                bool maxSizeParse = Int32.TryParse(textBoxSizeMax.Text, out maximumSize);
                if (minSizeParse && maxSizeParse)
                {
                    if (checkBoxPrice.Checked == false) 
                    { 
                        filterSize = selectedCars.Where(p => p.EngineSize >= minimumSize && p.EngineSize <= maximumSize).OrderBy(m => m.Make)
                       .ThenByDescending(y => y.Year)
                       .ThenBy(p => p.Price)
                       .ThenBy(c => c.Color)
                       .ToList().ToList();
                    }
                    else
                    {
                        filterSize = filterPrice.Where(p => p.EngineSize >= minimumSize && p.EngineSize <= maximumSize).OrderBy(m => m.Make)
                       .ThenByDescending(y => y.Year)
                       .ThenBy(p => p.Price)
                       .ThenBy(c => c.Color)
                       .ToList().ToList();
                    }
                    if (filterSize.Count() > 0)
                    {
                        foreach (var car in filterSize)
                        {
                            dataGridViewSelectedCars.Rows.Add(car.Make, car.Year, car.Color, car.EngineSize, car.Price, car.Dealer);
                        }
                        labelCountSelectedCars.Text = filterSize.Count().ToString();
                        labelAveragePriceSelectedCars.Text = filterSize.Average(s => s.Price).ToString("n1");
                    }
                }
                else
                {
                    MessageBox.Show("Engine size is missing or not an integer.");
                    labelCountSelectedCars.Text = "0";
                    labelAveragePriceSelectedCars.Text = "0";
                }
            }
            else
            {
                DisplayCars();
            }
        }
        

    }

    /// <summary>
    /// Car class which contains all car properties
    /// </summary>
    [Serializable]
    [XmlRoot]
    public class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal EngineSize { get; set; } // in litres
        public int Price { get; set; } // in dollars
        public string Dealer { get; set; } // dealer selling the car
        public Car() { }
    }
}