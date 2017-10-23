using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoreForm
{
    public partial class SwitchList : Form
    {
        public SwitchList()
        {
            InitializeComponent();
        }

        private void SwitchList_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\Aaron\documents\visual studio 2013\Projects\CoreProject\CoreForm\images\Form-818_A-Std-Small-Ft-Swi.jpg";
        }
    }
}
