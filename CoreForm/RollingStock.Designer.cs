namespace CoreForm
{
    partial class RollingStock
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
            this.listBoxCarTypeAttributes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArrCode = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.textBoxNextCar = new System.Windows.Forms.TextBox();
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.textBoxTrain = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.textBoxRoadNumber = new System.Windows.Forms.TextBox();
            this.checkBoxIsLastCar = new System.Windows.Forms.CheckBox();
            this.checkBoxIsFirstCar = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCapacityTons = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacityTons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCarTypeAttributes
            // 
            this.listBoxCarTypeAttributes.FormattingEnabled = true;
            this.listBoxCarTypeAttributes.Location = new System.Drawing.Point(262, 122);
            this.listBoxCarTypeAttributes.Name = "listBoxCarTypeAttributes";
            this.listBoxCarTypeAttributes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCarTypeAttributes.Size = new System.Drawing.Size(120, 108);
            this.listBoxCarTypeAttributes.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Car Attributes";
            // 
            // comboBoxArrCode
            // 
            this.comboBoxArrCode.FormattingEnabled = true;
            this.comboBoxArrCode.Location = new System.Drawing.Point(261, 74);
            this.comboBoxArrCode.Name = "comboBoxArrCode";
            this.comboBoxArrCode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArrCode.TabIndex = 60;
            this.comboBoxArrCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxArrCode_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(15, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 20);
            this.textBoxSearch.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Length";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(306, 298);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 55;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(225, 298);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 54;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(144, 298);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(15, 58);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(120, 264);
            this.listBoxCars.TabIndex = 52;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // textBoxNextCar
            // 
            this.textBoxNextCar.Location = new System.Drawing.Point(144, 265);
            this.textBoxNextCar.Name = "textBoxNextCar";
            this.textBoxNextCar.ReadOnly = true;
            this.textBoxNextCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxNextCar.TabIndex = 51;
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Location = new System.Drawing.Point(261, 264);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRFID.TabIndex = 50;
            // 
            // textBoxTrain
            // 
            this.textBoxTrain.Location = new System.Drawing.Point(144, 169);
            this.textBoxTrain.Name = "textBoxTrain";
            this.textBoxTrain.ReadOnly = true;
            this.textBoxTrain.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrain.TabIndex = 49;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(144, 218);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 48;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Location = new System.Drawing.Point(144, 120);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCarType.TabIndex = 46;
            this.comboBoxCarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarType_SelectedIndexChanged);
            // 
            // textBoxRoadNumber
            // 
            this.textBoxRoadNumber.Location = new System.Drawing.Point(144, 74);
            this.textBoxRoadNumber.Name = "textBoxRoadNumber";
            this.textBoxRoadNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoadNumber.TabIndex = 45;
            // 
            // checkBoxIsLastCar
            // 
            this.checkBoxIsLastCar.AutoSize = true;
            this.checkBoxIsLastCar.Enabled = false;
            this.checkBoxIsLastCar.Location = new System.Drawing.Point(378, 266);
            this.checkBoxIsLastCar.Name = "checkBoxIsLastCar";
            this.checkBoxIsLastCar.Size = new System.Drawing.Size(65, 17);
            this.checkBoxIsLastCar.TabIndex = 44;
            this.checkBoxIsLastCar.Text = "Last Car";
            this.checkBoxIsLastCar.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsFirstCar
            // 
            this.checkBoxIsFirstCar.AutoSize = true;
            this.checkBoxIsFirstCar.Enabled = false;
            this.checkBoxIsFirstCar.Location = new System.Drawing.Point(449, 266);
            this.checkBoxIsFirstCar.Name = "checkBoxIsFirstCar";
            this.checkBoxIsFirstCar.Size = new System.Drawing.Size(64, 17);
            this.checkBoxIsFirstCar.TabIndex = 43;
            this.checkBoxIsFirstCar.Text = "First Car";
            this.checkBoxIsFirstCar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Next Car";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Train";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "RFID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Capacity Tons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Car Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ARR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Road Number";
            // 
            // numericUpDownCapacityTons
            // 
            this.numericUpDownCapacityTons.Location = new System.Drawing.Point(515, 75);
            this.numericUpDownCapacityTons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCapacityTons.Name = "numericUpDownCapacityTons";
            this.numericUpDownCapacityTons.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCapacityTons.TabIndex = 63;
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(402, 75);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownLength.TabIndex = 64;
            // 
            // RollingStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 336);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.numericUpDownCapacityTons);
            this.Controls.Add(this.listBoxCarTypeAttributes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxArrCode);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.textBoxNextCar);
            this.Controls.Add(this.textBoxRFID);
            this.Controls.Add(this.textBoxTrain);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.textBoxRoadNumber);
            this.Controls.Add(this.checkBoxIsLastCar);
            this.Controls.Add(this.checkBoxIsFirstCar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RollingStock";
            this.Text = "RollingStock";
            this.Load += new System.EventHandler(this.RollingStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacityTons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarTypeAttributes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArrCode;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.TextBox textBoxNextCar;
        private System.Windows.Forms.TextBox textBoxRFID;
        private System.Windows.Forms.TextBox textBoxTrain;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.TextBox textBoxRoadNumber;
        private System.Windows.Forms.CheckBox checkBoxIsLastCar;
        private System.Windows.Forms.CheckBox checkBoxIsFirstCar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacityTons;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
    }
}