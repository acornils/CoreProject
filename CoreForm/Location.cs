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
    public partial class Location : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Location> location;

        public Location()
        {
            InitializeComponent();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            refreshListBox();
        }

        private void refreshListBox()
        {
            CoreWebService.LocationListResponse response = client.listLocations("");
            location = response.Data.ToList<CoreWebService.Location>();
            listBoxLocation.DataSource = location;
            listBoxLocation.DisplayMember = "name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.LocationResponse repsonse = client.addLocation(textBoxName.Text, textBoxShortName.Text, textBoxRFIDLocation.Text, numericUpDownScannerHead.Value.ToString(), checkBoxIsRFID.Checked);
            refreshListBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoreWebService.LocationResponse repsonse = client.updateLocation(location[listBoxLocation.SelectedIndex].ID, textBoxName.Text, textBoxShortName.Text, textBoxRFIDLocation.Text, numericUpDownScannerHead.Value.ToString(), checkBoxIsRFID.Checked);            
            refreshListBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            client.deleteLocation(location[listBoxLocation.SelectedIndex].ID);
            refreshListBox();
        }

        private void listBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = location[listBoxLocation.SelectedIndex].name;
            textBoxShortName.Text = location[listBoxLocation.SelectedIndex].shortName;
            textBoxRFIDLocation.Text = location[listBoxLocation.SelectedIndex].ScannerMAC;
            numericUpDownScannerHead.Value = Convert.ToDecimal(location[listBoxLocation.SelectedIndex].ScannerHead);
            checkBoxIsRFID.Checked = Convert.ToBoolean(location[listBoxLocation.SelectedIndex].isRFIDRead);
        }
    }
}
