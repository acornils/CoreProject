namespace CoreForm
{
    partial class Cars
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxIsFirstCar = new System.Windows.Forms.CheckBox();
            this.checkBoxIsLastCar = new System.Windows.Forms.CheckBox();
            this.textBoxRoadNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.textBoxCapacityTons = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTrain = new System.Windows.Forms.TextBox();
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.textBoxNextCar = new System.Windows.Forms.TextBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxArrCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Road Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Capacity Tons";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "RFID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Train";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Next Car";
            // 
            // checkBoxIsFirstCar
            // 
            this.checkBoxIsFirstCar.AutoSize = true;
            this.checkBoxIsFirstCar.Enabled = false;
            this.checkBoxIsFirstCar.Location = new System.Drawing.Point(447, 266);
            this.checkBoxIsFirstCar.Name = "checkBoxIsFirstCar";
            this.checkBoxIsFirstCar.Size = new System.Drawing.Size(64, 17);
            this.checkBoxIsFirstCar.TabIndex = 11;
            this.checkBoxIsFirstCar.Text = "First Car";
            this.checkBoxIsFirstCar.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsLastCar
            // 
            this.checkBoxIsLastCar.AutoSize = true;
            this.checkBoxIsLastCar.Enabled = false;
            this.checkBoxIsLastCar.Location = new System.Drawing.Point(376, 266);
            this.checkBoxIsLastCar.Name = "checkBoxIsLastCar";
            this.checkBoxIsLastCar.Size = new System.Drawing.Size(65, 17);
            this.checkBoxIsLastCar.TabIndex = 12;
            this.checkBoxIsLastCar.Text = "Last Car";
            this.checkBoxIsLastCar.UseVisualStyleBackColor = true;
            // 
            // textBoxRoadNumber
            // 
            this.textBoxRoadNumber.Location = new System.Drawing.Point(142, 74);
            this.textBoxRoadNumber.Name = "textBoxRoadNumber";
            this.textBoxRoadNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoadNumber.TabIndex = 13;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Location = new System.Drawing.Point(142, 120);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCarType.TabIndex = 15;
            // 
            // textBoxCapacityTons
            // 
            this.textBoxCapacityTons.Location = new System.Drawing.Point(513, 75);
            this.textBoxCapacityTons.Name = "textBoxCapacityTons";
            this.textBoxCapacityTons.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacityTons.TabIndex = 18;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(142, 218);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 19;
            // 
            // textBoxTrain
            // 
            this.textBoxTrain.Location = new System.Drawing.Point(142, 169);
            this.textBoxTrain.Name = "textBoxTrain";
            this.textBoxTrain.ReadOnly = true;
            this.textBoxTrain.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrain.TabIndex = 21;
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Location = new System.Drawing.Point(259, 264);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRFID.TabIndex = 22;
            // 
            // textBoxNextCar
            // 
            this.textBoxNextCar.Location = new System.Drawing.Point(142, 265);
            this.textBoxNextCar.Name = "textBoxNextCar";
            this.textBoxNextCar.ReadOnly = true;
            this.textBoxNextCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxNextCar.TabIndex = 23;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(13, 58);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(120, 264);
            this.listBoxCars.TabIndex = 24;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(142, 298);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(223, 298);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(304, 298);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Length";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(398, 75);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(96, 20);
            this.textBoxLength.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Filter";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(13, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 20);
            this.textBoxSearch.TabIndex = 31;
            // 
            // comboBoxArrCode
            // 
            this.comboBoxArrCode.FormattingEnabled = true;
            this.comboBoxArrCode.Location = new System.Drawing.Point(259, 74);
            this.comboBoxArrCode.Name = "comboBoxArrCode";
            this.comboBoxArrCode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArrCode.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Car Attributes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 34;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 335);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxArrCode);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.textBoxNextCar);
            this.Controls.Add(this.textBoxRFID);
            this.Controls.Add(this.textBoxTrain);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxCapacityTons);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cars";
            this.Text = "Cars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxIsFirstCar;
        private System.Windows.Forms.CheckBox checkBoxIsLastCar;
        private System.Windows.Forms.TextBox textBoxRoadNumber;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.TextBox textBoxCapacityTons;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxTrain;
        private System.Windows.Forms.TextBox textBoxRFID;
        private System.Windows.Forms.TextBox textBoxNextCar;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxArrCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}