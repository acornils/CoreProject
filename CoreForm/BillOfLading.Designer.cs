namespace CoreForm
{
    partial class BillOfLading
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
            this.listBoxBillOfLading = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxConsignee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxShipper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRequestedCarType = new System.Windows.Forms.ComboBox();
            this.numericUpDownRequestedLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCapacityTons = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNoPkgs = new System.Windows.Forms.TextBox();
            this.textBoxDescOfArticles = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.listBoxPath = new System.Windows.Forms.ListBox();
            this.listBoxCarTypeAttributes = new System.Windows.Forms.ListBox();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonRemovePath = new System.Windows.Forms.Button();
            this.checkBoxPreIce = new System.Windows.Forms.CheckBox();
            this.checkBoxInitialIce = new System.Windows.Forms.CheckBox();
            this.checkBoxIsPerishable = new System.Windows.Forms.CheckBox();
            this.checkBoxIsLiveStock = new System.Windows.Forms.CheckBox();
            this.checkBoxReturnEmpty = new System.Windows.Forms.CheckBox();
            this.checkBoxReverseRoute = new System.Windows.Forms.CheckBox();
            this.comboBoxNextWaybill = new System.Windows.Forms.ComboBox();
            this.checkBoxNextWaybill = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownCarsPerDay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownLoadTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUnloadTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestedLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacityTons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnloadTime)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxBillOfLading
            // 
            this.listBoxBillOfLading.FormattingEnabled = true;
            this.listBoxBillOfLading.Location = new System.Drawing.Point(13, 43);
            this.listBoxBillOfLading.Name = "listBoxBillOfLading";
            this.listBoxBillOfLading.Size = new System.Drawing.Size(228, 459);
            this.listBoxBillOfLading.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(141, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consignee";
            // 
            // comboBoxConsignee
            // 
            this.comboBoxConsignee.FormattingEnabled = true;
            this.comboBoxConsignee.Location = new System.Drawing.Point(435, 56);
            this.comboBoxConsignee.Name = "comboBoxConsignee";
            this.comboBoxConsignee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConsignee.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shipper";
            // 
            // comboBoxShipper
            // 
            this.comboBoxShipper.FormattingEnabled = true;
            this.comboBoxShipper.Location = new System.Drawing.Point(271, 56);
            this.comboBoxShipper.Name = "comboBoxShipper";
            this.comboBoxShipper.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShipper.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requested Car Type";
            // 
            // comboBoxRequestedCarType
            // 
            this.comboBoxRequestedCarType.FormattingEnabled = true;
            this.comboBoxRequestedCarType.Location = new System.Drawing.Point(600, 56);
            this.comboBoxRequestedCarType.Name = "comboBoxRequestedCarType";
            this.comboBoxRequestedCarType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRequestedCarType.TabIndex = 8;
            this.comboBoxRequestedCarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRequestedCarType_SelectedIndexChanged);
            // 
            // numericUpDownRequestedLength
            // 
            this.numericUpDownRequestedLength.Location = new System.Drawing.Point(601, 127);
            this.numericUpDownRequestedLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRequestedLength.Name = "numericUpDownRequestedLength";
            this.numericUpDownRequestedLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRequestedLength.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Requested Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Requested Capacity Tons";
            // 
            // numericUpDownCapacityTons
            // 
            this.numericUpDownCapacityTons.Location = new System.Drawing.Point(600, 200);
            this.numericUpDownCapacityTons.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCapacityTons.Name = "numericUpDownCapacityTons";
            this.numericUpDownCapacityTons.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCapacityTons.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "No Pkgs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description of Articles";
            // 
            // textBoxNoPkgs
            // 
            this.textBoxNoPkgs.Location = new System.Drawing.Point(272, 126);
            this.textBoxNoPkgs.Name = "textBoxNoPkgs";
            this.textBoxNoPkgs.Size = new System.Drawing.Size(118, 20);
            this.textBoxNoPkgs.TabIndex = 15;
            // 
            // textBoxDescOfArticles
            // 
            this.textBoxDescOfArticles.Location = new System.Drawing.Point(435, 125);
            this.textBoxDescOfArticles.Name = "textBoxDescOfArticles";
            this.textBoxDescOfArticles.Size = new System.Drawing.Size(124, 20);
            this.textBoxDescOfArticles.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 511);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(94, 511);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(175, 511);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.AllowDrop = true;
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(272, 200);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(120, 173);
            this.listBoxLocations.TabIndex = 20;
            // 
            // listBoxPath
            // 
            this.listBoxPath.AllowDrop = true;
            this.listBoxPath.FormattingEnabled = true;
            this.listBoxPath.Location = new System.Drawing.Point(435, 200);
            this.listBoxPath.Name = "listBoxPath";
            this.listBoxPath.Size = new System.Drawing.Size(120, 173);
            this.listBoxPath.TabIndex = 21;
            // 
            // listBoxCarTypeAttributes
            // 
            this.listBoxCarTypeAttributes.FormattingEnabled = true;
            this.listBoxCarTypeAttributes.Location = new System.Drawing.Point(601, 250);
            this.listBoxCarTypeAttributes.Name = "listBoxCarTypeAttributes";
            this.listBoxCarTypeAttributes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCarTypeAttributes.Size = new System.Drawing.Size(120, 121);
            this.listBoxCarTypeAttributes.TabIndex = 22;
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.Location = new System.Drawing.Point(398, 255);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(31, 23);
            this.buttonAddPath.TabIndex = 23;
            this.buttonAddPath.Text = ">>";
            this.buttonAddPath.UseVisualStyleBackColor = true;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
            // 
            // buttonRemovePath
            // 
            this.buttonRemovePath.Location = new System.Drawing.Point(398, 284);
            this.buttonRemovePath.Name = "buttonRemovePath";
            this.buttonRemovePath.Size = new System.Drawing.Size(31, 23);
            this.buttonRemovePath.TabIndex = 24;
            this.buttonRemovePath.Text = "<<";
            this.buttonRemovePath.UseVisualStyleBackColor = true;
            this.buttonRemovePath.Click += new System.EventHandler(this.buttonRemovePath_Click);
            // 
            // checkBoxPreIce
            // 
            this.checkBoxPreIce.AutoSize = true;
            this.checkBoxPreIce.Enabled = false;
            this.checkBoxPreIce.Location = new System.Drawing.Point(272, 413);
            this.checkBoxPreIce.Name = "checkBoxPreIce";
            this.checkBoxPreIce.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPreIce.TabIndex = 25;
            this.checkBoxPreIce.Text = "Pre Ice";
            this.checkBoxPreIce.UseVisualStyleBackColor = true;
            // 
            // checkBoxInitialIce
            // 
            this.checkBoxInitialIce.AutoSize = true;
            this.checkBoxInitialIce.Enabled = false;
            this.checkBoxInitialIce.Location = new System.Drawing.Point(272, 436);
            this.checkBoxInitialIce.Name = "checkBoxInitialIce";
            this.checkBoxInitialIce.Size = new System.Drawing.Size(68, 17);
            this.checkBoxInitialIce.TabIndex = 26;
            this.checkBoxInitialIce.Text = "Initial Ice";
            this.checkBoxInitialIce.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsPerishable
            // 
            this.checkBoxIsPerishable.AutoSize = true;
            this.checkBoxIsPerishable.Location = new System.Drawing.Point(272, 390);
            this.checkBoxIsPerishable.Name = "checkBoxIsPerishable";
            this.checkBoxIsPerishable.Size = new System.Drawing.Size(112, 17);
            this.checkBoxIsPerishable.TabIndex = 27;
            this.checkBoxIsPerishable.Text = "Perishable Waybill";
            this.checkBoxIsPerishable.UseVisualStyleBackColor = true;
            this.checkBoxIsPerishable.CheckedChanged += new System.EventHandler(this.checkBoxIsPerishable_CheckedChanged);
            // 
            // checkBoxIsLiveStock
            // 
            this.checkBoxIsLiveStock.AutoSize = true;
            this.checkBoxIsLiveStock.Location = new System.Drawing.Point(438, 390);
            this.checkBoxIsLiveStock.Name = "checkBoxIsLiveStock";
            this.checkBoxIsLiveStock.Size = new System.Drawing.Size(114, 17);
            this.checkBoxIsLiveStock.TabIndex = 28;
            this.checkBoxIsLiveStock.Text = "Live Stock Waybill";
            this.checkBoxIsLiveStock.UseVisualStyleBackColor = true;
            this.checkBoxIsLiveStock.CheckedChanged += new System.EventHandler(this.checkBoxIsLiveStock_CheckedChanged);
            // 
            // checkBoxReturnEmpty
            // 
            this.checkBoxReturnEmpty.AutoSize = true;
            this.checkBoxReturnEmpty.Location = new System.Drawing.Point(601, 413);
            this.checkBoxReturnEmpty.Name = "checkBoxReturnEmpty";
            this.checkBoxReturnEmpty.Size = new System.Drawing.Size(90, 17);
            this.checkBoxReturnEmpty.TabIndex = 29;
            this.checkBoxReturnEmpty.Text = "Return Empty";
            this.checkBoxReturnEmpty.UseVisualStyleBackColor = true;
            // 
            // checkBoxReverseRoute
            // 
            this.checkBoxReverseRoute.AutoSize = true;
            this.checkBoxReverseRoute.Location = new System.Drawing.Point(601, 390);
            this.checkBoxReverseRoute.Name = "checkBoxReverseRoute";
            this.checkBoxReverseRoute.Size = new System.Drawing.Size(98, 17);
            this.checkBoxReverseRoute.TabIndex = 30;
            this.checkBoxReverseRoute.Text = "Reverse Route";
            this.checkBoxReverseRoute.UseVisualStyleBackColor = true;
            // 
            // comboBoxNextWaybill
            // 
            this.comboBoxNextWaybill.FormattingEnabled = true;
            this.comboBoxNextWaybill.Location = new System.Drawing.Point(601, 462);
            this.comboBoxNextWaybill.Name = "comboBoxNextWaybill";
            this.comboBoxNextWaybill.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNextWaybill.TabIndex = 32;
            // 
            // checkBoxNextWaybill
            // 
            this.checkBoxNextWaybill.AutoSize = true;
            this.checkBoxNextWaybill.Location = new System.Drawing.Point(600, 437);
            this.checkBoxNextWaybill.Name = "checkBoxNextWaybill";
            this.checkBoxNextWaybill.Size = new System.Drawing.Size(85, 17);
            this.checkBoxNextWaybill.TabIndex = 33;
            this.checkBoxNextWaybill.Text = "Next Waybill";
            this.checkBoxNextWaybill.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Path";
            // 
            // numericUpDownCarsPerDay
            // 
            this.numericUpDownCarsPerDay.DecimalPlaces = 2;
            this.numericUpDownCarsPerDay.Location = new System.Drawing.Point(435, 462);
            this.numericUpDownCarsPerDay.Name = "numericUpDownCarsPerDay";
            this.numericUpDownCarsPerDay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCarsPerDay.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cars Per Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Load Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(600, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Unload Time";
            // 
            // numericUpDownLoadTime
            // 
            this.numericUpDownLoadTime.Location = new System.Drawing.Point(435, 511);
            this.numericUpDownLoadTime.Name = "numericUpDownLoadTime";
            this.numericUpDownLoadTime.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLoadTime.TabIndex = 40;
            // 
            // numericUpDownUnloadTime
            // 
            this.numericUpDownUnloadTime.Location = new System.Drawing.Point(601, 510);
            this.numericUpDownUnloadTime.Name = "numericUpDownUnloadTime";
            this.numericUpDownUnloadTime.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUnloadTime.TabIndex = 41;
            // 
            // BillOfLading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 546);
            this.Controls.Add(this.numericUpDownUnloadTime);
            this.Controls.Add(this.numericUpDownLoadTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownCarsPerDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxNextWaybill);
            this.Controls.Add(this.comboBoxNextWaybill);
            this.Controls.Add(this.checkBoxReverseRoute);
            this.Controls.Add(this.checkBoxReturnEmpty);
            this.Controls.Add(this.checkBoxIsLiveStock);
            this.Controls.Add(this.checkBoxIsPerishable);
            this.Controls.Add(this.checkBoxInitialIce);
            this.Controls.Add(this.checkBoxPreIce);
            this.Controls.Add(this.buttonRemovePath);
            this.Controls.Add(this.buttonAddPath);
            this.Controls.Add(this.listBoxCarTypeAttributes);
            this.Controls.Add(this.listBoxPath);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDescOfArticles);
            this.Controls.Add(this.textBoxNoPkgs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCapacityTons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownRequestedLength);
            this.Controls.Add(this.comboBoxRequestedCarType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxShipper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxConsignee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxBillOfLading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BillOfLading";
            this.Text = "Bill Of Lading";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestedLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacityTons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnloadTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBillOfLading;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxConsignee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxShipper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRequestedCarType;
        private System.Windows.Forms.NumericUpDown numericUpDownRequestedLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacityTons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNoPkgs;
        private System.Windows.Forms.TextBox textBoxDescOfArticles;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.ListBox listBoxPath;
        private System.Windows.Forms.ListBox listBoxCarTypeAttributes;
        private System.Windows.Forms.Button buttonAddPath;
        private System.Windows.Forms.Button buttonRemovePath;
        private System.Windows.Forms.CheckBox checkBoxPreIce;
        private System.Windows.Forms.CheckBox checkBoxInitialIce;
        private System.Windows.Forms.CheckBox checkBoxIsPerishable;
        private System.Windows.Forms.CheckBox checkBoxIsLiveStock;
        private System.Windows.Forms.CheckBox checkBoxReturnEmpty;
        private System.Windows.Forms.CheckBox checkBoxReverseRoute;
        private System.Windows.Forms.ComboBox comboBoxNextWaybill;
        private System.Windows.Forms.CheckBox checkBoxNextWaybill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownCarsPerDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownLoadTime;
        private System.Windows.Forms.NumericUpDown numericUpDownUnloadTime;
    }
}