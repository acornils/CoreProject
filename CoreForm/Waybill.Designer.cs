namespace CoreForm
{
    partial class Waybill
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
            this.listBoxWaybillTemplates = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxAssignCar = new System.Windows.Forms.CheckBox();
            this.comboBoxRollingStock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxWaybillTemplates
            // 
            this.listBoxWaybillTemplates.FormattingEnabled = true;
            this.listBoxWaybillTemplates.Location = new System.Drawing.Point(12, 42);
            this.listBoxWaybillTemplates.Name = "listBoxWaybillTemplates";
            this.listBoxWaybillTemplates.Size = new System.Drawing.Size(296, 316);
            this.listBoxWaybillTemplates.TabIndex = 0;
            this.listBoxWaybillTemplates.SelectedIndexChanged += new System.EventHandler(this.listBoxWaybillTemplates_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(296, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(314, 335);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxAssignCar
            // 
            this.checkBoxAssignCar.AutoSize = true;
            this.checkBoxAssignCar.Location = new System.Drawing.Point(315, 42);
            this.checkBoxAssignCar.Name = "checkBoxAssignCar";
            this.checkBoxAssignCar.Size = new System.Drawing.Size(76, 17);
            this.checkBoxAssignCar.TabIndex = 3;
            this.checkBoxAssignCar.Text = "Assign Car";
            this.checkBoxAssignCar.UseVisualStyleBackColor = true;
            this.checkBoxAssignCar.CheckedChanged += new System.EventHandler(this.checkBoxAssignCar_CheckedChanged);
            // 
            // comboBoxRollingStock
            // 
            this.comboBoxRollingStock.FormattingEnabled = true;
            this.comboBoxRollingStock.Location = new System.Drawing.Point(314, 65);
            this.comboBoxRollingStock.Name = "comboBoxRollingStock";
            this.comboBoxRollingStock.Size = new System.Drawing.Size(182, 21);
            this.comboBoxRollingStock.TabIndex = 4;
            // 
            // Waybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.comboBoxRollingStock);
            this.Controls.Add(this.checkBoxAssignCar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxWaybillTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Waybill";
            this.Text = "Waybill";
            this.Load += new System.EventHandler(this.Waybill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWaybillTemplates;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxAssignCar;
        private System.Windows.Forms.ComboBox comboBoxRollingStock;
    }
}