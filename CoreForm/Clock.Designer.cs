namespace CoreForm
{
    partial class Clock
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSetTime = new System.Windows.Forms.Button();
            this.radioButtonAM = new System.Windows.Forms.RadioButton();
            this.radioButtonPM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Location = new System.Drawing.Point(96, 148);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTime.TabIndex = 1;
            this.buttonSetTime.Text = "Set";
            this.buttonSetTime.UseVisualStyleBackColor = true;
            this.buttonSetTime.Click += new System.EventHandler(this.buttonSetTime_Click);
            // 
            // radioButtonAM
            // 
            this.radioButtonAM.AutoSize = true;
            this.radioButtonAM.Location = new System.Drawing.Point(87, 101);
            this.radioButtonAM.Name = "radioButtonAM";
            this.radioButtonAM.Size = new System.Drawing.Size(41, 17);
            this.radioButtonAM.TabIndex = 2;
            this.radioButtonAM.TabStop = true;
            this.radioButtonAM.Text = "AM";
            this.radioButtonAM.UseVisualStyleBackColor = true;
            this.radioButtonAM.CheckedChanged += new System.EventHandler(this.radioButtonAM_CheckedChanged);
            // 
            // radioButtonPM
            // 
            this.radioButtonPM.AutoSize = true;
            this.radioButtonPM.Location = new System.Drawing.Point(134, 101);
            this.radioButtonPM.Name = "radioButtonPM";
            this.radioButtonPM.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPM.TabIndex = 3;
            this.radioButtonPM.TabStop = true;
            this.radioButtonPM.Text = "PM";
            this.radioButtonPM.UseVisualStyleBackColor = true;
            this.radioButtonPM.CheckedChanged += new System.EventHandler(this.radioButtonPM_CheckedChanged);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radioButtonPM);
            this.Controls.Add(this.radioButtonAM);
            this.Controls.Add(this.buttonSetTime);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSetTime;
        private System.Windows.Forms.RadioButton radioButtonAM;
        private System.Windows.Forms.RadioButton radioButtonPM;
    }
}