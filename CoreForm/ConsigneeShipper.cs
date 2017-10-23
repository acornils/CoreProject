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
    public partial class ConsigneeShipper : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public ConsigneeShipper()
        {
            InitializeComponent();
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private void ConsigneeShipper_Load(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeListResponse arrCodes = client.listAllArrCode("");
            if (arrCodes.Status == 0)
            {
                comboBoxRailroad.DisplayMember = "Carrier";
                comboBoxRailroad.ValueMember = "ID";
                comboBoxRailroad.DataSource = arrCodes.Data;
            }

            CoreWebService.LocationListResponse locations = client.listLocations("");
            if (locations.Status == 0)
            {
                comboBoxLocation.DisplayMember = "name";
                comboBoxLocation.ValueMember = "ID";
                comboBoxLocation.DataSource = locations.Data;
            }

            CoreWebService.ConsigneeShipperListResponse consigneeShipper = client.listConsigneeShipper("");
            if (consigneeShipper.Status == 0)
            {
                listBoxConsigneeShipper.DisplayMember = "name";
                listBoxConsigneeShipper.ValueMember = "ID";
                listBoxConsigneeShipper.DataSource = consigneeShipper.Data;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            CoreWebService.ConsigneeShipperListResponse response = client.listConsigneeShipper(textBoxSearch.Text);

            if (response.Status == 0 || response.Status == 3)
            {
                listBoxConsigneeShipper.DisplayMember = "name";
                listBoxConsigneeShipper.ValueMember = "ID";
                listBoxConsigneeShipper.DataSource = response.Data;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.ConsigneeShipperResponse response = client.addConsigneeShipper(textBoxName.Text, (int)comboBoxLocation.SelectedValue, (int)comboBoxRailroad.SelectedValue);

            if(response.Status == 0)
            {
                CoreWebService.ConsigneeShipperListResponse consigneeShipper = client.listConsigneeShipper("");
                listBoxConsigneeShipper.DisplayMember = "name";
                listBoxConsigneeShipper.ValueMember = "ID";
                listBoxConsigneeShipper.DataSource = consigneeShipper.Data;
                listBoxConsigneeShipper.SelectedValue = response.Data.ID;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void listBoxConsigneeShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoreWebService.ConsigneeShipperResponse response = client.getConsigneeShipper((int)listBoxConsigneeShipper.SelectedValue);

            if(response.Status == 0)
            {
                textBoxName.Text = response.Data.name;
                comboBoxLocation.SelectedValue = response.Data.locationID;
                comboBoxRailroad.SelectedValue = response.Data.aarCodeID;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoreWebService.ConsigneeShipperResponse response = client.updateConsigneeShipper((int)listBoxConsigneeShipper.SelectedValue, textBoxName.Text, (int)comboBoxLocation.SelectedValue, (int)comboBoxRailroad.SelectedValue);

            if (response.Status == 0)
            {
                CoreWebService.ConsigneeShipperListResponse consigneeShipper = client.listConsigneeShipper("");
                listBoxConsigneeShipper.DisplayMember = "name";
                listBoxConsigneeShipper.ValueMember = "ID";
                listBoxConsigneeShipper.DataSource = consigneeShipper.Data;
                listBoxConsigneeShipper.SelectedValue = response.Data.ID;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CoreWebService.ConsigneeShipperResponse response = client.deleteConsigneeShipper((int)listBoxConsigneeShipper.SelectedValue);
            int i = listBoxConsigneeShipper.SelectedIndex;

            if (response.Status == 0)
            {
                CoreWebService.ConsigneeShipperListResponse consigneeShipper = client.listConsigneeShipper("");
                listBoxConsigneeShipper.DisplayMember = "name";
                listBoxConsigneeShipper.ValueMember = "ID";
                listBoxConsigneeShipper.DataSource = consigneeShipper.Data;
                listBoxConsigneeShipper.SelectedIndex = i - 1;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}
