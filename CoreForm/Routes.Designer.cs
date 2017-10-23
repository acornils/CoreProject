namespace CoreForm
{
    partial class Routes
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
            this.listBoxNewRoute = new System.Windows.Forms.ListBox();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.buttonRemoveLocation = new System.Windows.Forms.Button();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNewRoute
            // 
            this.listBoxNewRoute.FormattingEnabled = true;
            this.listBoxNewRoute.Location = new System.Drawing.Point(12, 12);
            this.listBoxNewRoute.Name = "listBoxNewRoute";
            this.listBoxNewRoute.Size = new System.Drawing.Size(120, 407);
            this.listBoxNewRoute.TabIndex = 0;
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(180, 33);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(120, 173);
            this.listBoxLocations.TabIndex = 1;
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(180, 246);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(120, 173);
            this.listBoxRoutes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(322, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(322, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(208, 101);
            this.textBoxDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Symbol";
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(325, 263);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(100, 20);
            this.textBoxSymbol.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Locations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Routes";
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Location = new System.Drawing.Point(139, 76);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(35, 23);
            this.buttonAddLocation.TabIndex = 11;
            this.buttonAddLocation.Text = "<<";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // buttonRemoveLocation
            // 
            this.buttonRemoveLocation.Location = new System.Drawing.Point(139, 105);
            this.buttonRemoveLocation.Name = "buttonRemoveLocation";
            this.buttonRemoveLocation.Size = new System.Drawing.Size(35, 23);
            this.buttonRemoveLocation.TabIndex = 12;
            this.buttonRemoveLocation.Text = ">>";
            this.buttonRemoveLocation.UseVisualStyleBackColor = true;
            this.buttonRemoveLocation.Click += new System.EventHandler(this.buttonRemoveLocation_Click);
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(139, 285);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(35, 23);
            this.buttonAddRoute.TabIndex = 13;
            this.buttonAddRoute.Text = "<<";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 467);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.buttonRemoveLocation);
            this.Controls.Add(this.buttonAddLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRoutes);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.listBoxNewRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNewRoute;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Button buttonRemoveLocation;
        private System.Windows.Forms.Button buttonAddRoute;
    }
}