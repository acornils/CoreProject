namespace CoreForm
{
    partial class Route
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
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.buttonNewRoute = new System.Windows.Forms.Button();
            this.buttonDeleteRoute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRouteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRouteDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPath = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.checkBoxIsCaptive = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Routes";
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(15, 25);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(142, 394);
            this.listBoxRoutes.TabIndex = 1;
            this.listBoxRoutes.SelectedIndexChanged += new System.EventHandler(this.listBoxRoutes_SelectedIndexChanged);
            // 
            // buttonNewRoute
            // 
            this.buttonNewRoute.Location = new System.Drawing.Point(15, 426);
            this.buttonNewRoute.Name = "buttonNewRoute";
            this.buttonNewRoute.Size = new System.Drawing.Size(62, 23);
            this.buttonNewRoute.TabIndex = 2;
            this.buttonNewRoute.Text = "New";
            this.buttonNewRoute.UseVisualStyleBackColor = true;
            this.buttonNewRoute.Click += new System.EventHandler(this.buttonNewRoute_Click);
            // 
            // buttonDeleteRoute
            // 
            this.buttonDeleteRoute.Location = new System.Drawing.Point(94, 426);
            this.buttonDeleteRoute.Name = "buttonDeleteRoute";
            this.buttonDeleteRoute.Size = new System.Drawing.Size(64, 23);
            this.buttonDeleteRoute.TabIndex = 3;
            this.buttonDeleteRoute.Text = "Delete";
            this.buttonDeleteRoute.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Route Name";
            // 
            // textBoxRouteName
            // 
            this.textBoxRouteName.Location = new System.Drawing.Point(185, 26);
            this.textBoxRouteName.Name = "textBoxRouteName";
            this.textBoxRouteName.Size = new System.Drawing.Size(185, 20);
            this.textBoxRouteName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Route Description";
            // 
            // textBoxRouteDescription
            // 
            this.textBoxRouteDescription.Location = new System.Drawing.Point(188, 84);
            this.textBoxRouteDescription.Multiline = true;
            this.textBoxRouteDescription.Name = "textBoxRouteDescription";
            this.textBoxRouteDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRouteDescription.Size = new System.Drawing.Size(182, 161);
            this.textBoxRouteDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Locations";
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(407, 84);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(152, 329);
            this.listBoxLocations.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Path";
            // 
            // listBoxPath
            // 
            this.listBoxPath.FormattingEnabled = true;
            this.listBoxPath.Location = new System.Drawing.Point(711, 84);
            this.listBoxPath.Name = "listBoxPath";
            this.listBoxPath.Size = new System.Drawing.Size(152, 329);
            this.listBoxPath.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Symbol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(595, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(595, 280);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 15;
            this.buttonRemove.Text = "<<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(585, 174);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(100, 20);
            this.textBoxSymbol.TabIndex = 16;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(585, 225);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 17;
            // 
            // checkBoxIsCaptive
            // 
            this.checkBoxIsCaptive.AutoSize = true;
            this.checkBoxIsCaptive.Location = new System.Drawing.Point(188, 256);
            this.checkBoxIsCaptive.Name = "checkBoxIsCaptive";
            this.checkBoxIsCaptive.Size = new System.Drawing.Size(73, 17);
            this.checkBoxIsCaptive.TabIndex = 18;
            this.checkBoxIsCaptive.Text = "Is Captive";
            this.checkBoxIsCaptive.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(185, 279);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 457);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxIsCaptive);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRouteDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRouteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteRoute);
            this.Controls.Add(this.buttonNewRoute);
            this.Controls.Add(this.listBoxRoutes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Route";
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button buttonNewRoute;
        private System.Windows.Forms.Button buttonDeleteRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRouteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRouteDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxIsCaptive;
        private System.Windows.Forms.Button buttonUpdate;
    }
}