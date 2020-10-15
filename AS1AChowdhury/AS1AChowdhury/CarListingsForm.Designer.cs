namespace AS1AChowdhury
{
    partial class CarListingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAllCars = new System.Windows.Forms.DataGridView();
            this.listBoxMakes = new System.Windows.Forms.ListBox();
            this.listBoxYears = new System.Windows.Forms.ListBox();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.listBoxDealers = new System.Windows.Forms.ListBox();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.textBoxSizeMin = new System.Windows.Forms.TextBox();
            this.textBoxSizeMax = new System.Windows.Forms.TextBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxSize = new System.Windows.Forms.CheckBox();
            this.dataGridViewSelectedCars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAveragePriceSelectedCars = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountAllCars = new System.Windows.Forms.Label();
            this.labelAveragePriceAllCars = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCountSelectedCars = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllCars
            // 
            this.dataGridViewAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCars.Location = new System.Drawing.Point(146, 102);
            this.dataGridViewAllCars.Name = "dataGridViewAllCars";
            this.dataGridViewAllCars.RowHeadersWidth = 82;
            this.dataGridViewAllCars.RowTemplate.Height = 33;
            this.dataGridViewAllCars.Size = new System.Drawing.Size(1023, 233);
            this.dataGridViewAllCars.TabIndex = 0;
            // 
            // listBoxMakes
            // 
            this.listBoxMakes.FormattingEnabled = true;
            this.listBoxMakes.ItemHeight = 25;
            this.listBoxMakes.Location = new System.Drawing.Point(147, 517);
            this.listBoxMakes.Name = "listBoxMakes";
            this.listBoxMakes.Size = new System.Drawing.Size(263, 229);
            this.listBoxMakes.TabIndex = 1;
            // 
            // listBoxYears
            // 
            this.listBoxYears.FormattingEnabled = true;
            this.listBoxYears.ItemHeight = 25;
            this.listBoxYears.Location = new System.Drawing.Point(478, 517);
            this.listBoxYears.Name = "listBoxYears";
            this.listBoxYears.Size = new System.Drawing.Size(129, 229);
            this.listBoxYears.TabIndex = 2;
            // 
            // listBoxColors
            // 
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 25;
            this.listBoxColors.Location = new System.Drawing.Point(660, 517);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(177, 229);
            this.listBoxColors.TabIndex = 3;
            // 
            // listBoxDealers
            // 
            this.listBoxDealers.FormattingEnabled = true;
            this.listBoxDealers.ItemHeight = 25;
            this.listBoxDealers.Location = new System.Drawing.Point(881, 517);
            this.listBoxDealers.Name = "listBoxDealers";
            this.listBoxDealers.Size = new System.Drawing.Size(282, 229);
            this.listBoxDealers.TabIndex = 4;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(620, 408);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(156, 46);
            this.buttonResetFilters.TabIndex = 5;
            this.buttonResetFilters.Text = "Reset Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(305, 774);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(210, 31);
            this.textBoxPriceMin.TabIndex = 6;
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(305, 830);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(210, 31);
            this.textBoxPriceMax.TabIndex = 7;
            // 
            // textBoxSizeMin
            // 
            this.textBoxSizeMin.Location = new System.Drawing.Point(850, 774);
            this.textBoxSizeMin.Name = "textBoxSizeMin";
            this.textBoxSizeMin.Size = new System.Drawing.Size(222, 31);
            this.textBoxSizeMin.TabIndex = 8;
            // 
            // textBoxSizeMax
            // 
            this.textBoxSizeMax.Location = new System.Drawing.Point(850, 830);
            this.textBoxSizeMax.Name = "textBoxSizeMax";
            this.textBoxSizeMax.Size = new System.Drawing.Size(222, 31);
            this.textBoxSizeMax.TabIndex = 9;
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(298, 885);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(197, 29);
            this.checkBoxPrice.TabIndex = 10;
            this.checkBoxPrice.Text = "Search on Price";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxSize
            // 
            this.checkBoxSize.AutoSize = true;
            this.checkBoxSize.Location = new System.Drawing.Point(850, 885);
            this.checkBoxSize.Name = "checkBoxSize";
            this.checkBoxSize.Size = new System.Drawing.Size(263, 29);
            this.checkBoxSize.TabIndex = 11;
            this.checkBoxSize.Text = "Search on Engine Size";
            this.checkBoxSize.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelectedCars
            // 
            this.dataGridViewSelectedCars.ColumnHeadersHeight = 46;
            this.dataGridViewSelectedCars.Location = new System.Drawing.Point(146, 983);
            this.dataGridViewSelectedCars.Name = "dataGridViewSelectedCars";
            this.dataGridViewSelectedCars.RowHeadersWidth = 82;
            this.dataGridViewSelectedCars.Size = new System.Drawing.Size(1026, 249);
            this.dataGridViewSelectedCars.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "All Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filters";
            // 
            // labelAveragePriceSelectedCars
            // 
            this.labelAveragePriceSelectedCars.AutoSize = true;
            this.labelAveragePriceSelectedCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAveragePriceSelectedCars.Location = new System.Drawing.Point(878, 1256);
            this.labelAveragePriceSelectedCars.Name = "labelAveragePriceSelectedCars";
            this.labelAveragePriceSelectedCars.Size = new System.Drawing.Size(72, 27);
            this.labelAveragePriceSelectedCars.TabIndex = 14;
            this.labelAveragePriceSelectedCars.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(782, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Average Price =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Count =";
            // 
            // labelCountAllCars
            // 
            this.labelCountAllCars.AutoSize = true;
            this.labelCountAllCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountAllCars.Location = new System.Drawing.Point(388, 353);
            this.labelCountAllCars.Name = "labelCountAllCars";
            this.labelCountAllCars.Size = new System.Drawing.Size(72, 27);
            this.labelCountAllCars.TabIndex = 17;
            this.labelCountAllCars.Text = "label6";
            // 
            // labelAveragePriceAllCars
            // 
            this.labelAveragePriceAllCars.AutoSize = true;
            this.labelAveragePriceAllCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAveragePriceAllCars.Location = new System.Drawing.Point(957, 353);
            this.labelAveragePriceAllCars.Name = "labelAveragePriceAllCars";
            this.labelAveragePriceAllCars.Size = new System.Drawing.Size(72, 27);
            this.labelAveragePriceAllCars.TabIndex = 18;
            this.labelAveragePriceAllCars.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 1256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Average Price =";
            // 
            // labelCountSelectedCars
            // 
            this.labelCountSelectedCars.AutoSize = true;
            this.labelCountSelectedCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountSelectedCars.Location = new System.Drawing.Point(371, 1256);
            this.labelCountSelectedCars.Name = "labelCountSelectedCars";
            this.labelCountSelectedCars.Size = new System.Drawing.Size(72, 27);
            this.labelCountSelectedCars.TabIndex = 20;
            this.labelCountSelectedCars.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 1256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Count =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(789, 830);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(789, 777);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 780);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(246, 830);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(171, 942);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 27);
            this.label15.TabIndex = 26;
            this.label15.Text = "Selected Cars";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(159, 782);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 27);
            this.label16.TabIndex = 28;
            this.label16.Text = "Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(662, 777);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 27);
            this.label17.TabIndex = 29;
            this.label17.Text = "Engine Size";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(876, 489);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 25);
            this.label18.TabIndex = 30;
            this.label18.Text = "Dealers";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(655, 489);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 25);
            this.label19.TabIndex = 31;
            this.label19.Text = "Colors";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(473, 489);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 25);
            this.label20.TabIndex = 32;
            this.label20.Text = "Years";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(142, 489);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 25);
            this.label21.TabIndex = 33;
            this.label21.Text = "Makes";
            // 
            // CarListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 1446);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelCountSelectedCars);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelAveragePriceAllCars);
            this.Controls.Add(this.labelCountAllCars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAveragePriceSelectedCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSelectedCars);
            this.Controls.Add(this.checkBoxSize);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.textBoxSizeMax);
            this.Controls.Add(this.textBoxSizeMin);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMin);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.listBoxDealers);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.listBoxYears);
            this.Controls.Add(this.listBoxMakes);
            this.Controls.Add(this.dataGridViewAllCars);
            this.Name = "CarListingForm";
            this.Text = " Assignment 1 - Car Listings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllCars;
        private System.Windows.Forms.ListBox listBoxMakes;
        private System.Windows.Forms.ListBox listBoxYears;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.ListBox listBoxDealers;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.TextBox textBoxSizeMin;
        private System.Windows.Forms.TextBox textBoxSizeMax;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.DataGridView dataGridViewSelectedCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAveragePriceSelectedCars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountAllCars;
        private System.Windows.Forms.Label labelAveragePriceAllCars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCountSelectedCars;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

