using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreForm
{
    public partial class Clock : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public Clock()
        {
            InitializeComponent();
        }

        private void buttonSetTime_Click(object sender, EventArgs e)
        {
            if(radioButtonAM.Checked == true)
            {
                DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0, 0);
                client.setSetting("time", dateTime.ToString());
            }
            else
            {
                DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 12, 0, 0, 0);
                client.setSetting("time", dateTime.ToString());
            }
            
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(client.getSetting("time").value);
            string amPM = dateTimePicker1.Value.ToString("tt");

            if(amPM == "AM")
            {
                radioButtonAM.Checked = true;
            }
            else
            {
                radioButtonPM.Checked = true;
            }
        }

        private void radioButtonAM_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAM.Checked == true)
            {
                radioButtonPM.Checked = false;
            }
        }

        private void radioButtonPM_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPM.Checked == true)
            {
                radioButtonAM.Checked = false;
            }
        }
    }
}
