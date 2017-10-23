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
    public partial class BillOfLading : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public BillOfLading()
        {
            InitializeComponent();

        }

        private void BillOfLadings_Load(object sender, EventArgs e)
        {
            CoreWebService.BillOfLadingListResponse waybillTemplates = client.listBillOfLading(textBoxSearch.Text);
            if(waybillTemplates.Status == 0)
            {
                listBoxBillOfLading.DisplayMember = "displayText";
                listBoxBillOfLading.ValueMember = "ID";
                listBoxBillOfLading.DataSource = waybillTemplates.Data;
            }

            CoreWebService.LocationListResponse locations = client.listLocations("");
            if (locations.Status == 0)
            {
                listBoxLocations.DisplayMember = "name";
                listBoxLocations.DataSource = locations.Data;
            }

            CoreWebService.ConsigneeShipperListResponse consignee = client.listConsigneeShipper("");
            if (consignee.Status == 0)
            {
                comboBoxConsignee.DisplayMember = "name";
                comboBoxConsignee.ValueMember = "ID";
                comboBoxConsignee.DataSource = consignee.Data;
            }

            CoreWebService.ConsigneeShipperListResponse shipper = client.listConsigneeShipper("");
            if(shipper.Status == 0)
            {
                comboBoxShipper.DisplayMember = "name";
                comboBoxShipper.ValueMember = "ID";
                comboBoxShipper.DataSource = shipper.Data;
            }

            CoreWebService.CarTypeListResponse carType = client.listCarTypes();
            if(carType.Status == 0)
            {
                comboBoxRequestedCarType.DisplayMember = "shortName";
                comboBoxRequestedCarType.ValueMember = "ID";
                comboBoxRequestedCarType.DataSource = carType.Data;
            }

            listBoxPath.DisplayMember = "name";
            listBoxPath.ValueMember = "ID";
        }

        private void comboBoxRequestedCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CoreWebService.CarTypeAttributeListResponse carTypeatrributes = client.listCarTypeAttributes((int)comboBoxRequestedCarType.SelectedValue);

                if (carTypeatrributes.Status == 0)
                {
                    listBoxCarTypeAttributes.DisplayMember = "attribute";
                    listBoxCarTypeAttributes.ValueMember = "ID";
                    listBoxCarTypeAttributes.DataSource = carTypeatrributes.Data;
                    listBoxCarTypeAttributes.ClearSelected();
                }

                CoreWebService.BillOfLadingCarTypeAttributesListResponse rollingStockAttribute = client.listBillOfLadingCartypeAttribute((int)listBoxBillOfLading.SelectedValue);

                for (int i = 0; i < rollingStockAttribute.Data.Length; i++)
                {
                    listBoxCarTypeAttributes.SelectedValue = rollingStockAttribute.Data[i].carTypeAttributeID;
                    int r = listBoxCarTypeAttributes.SelectedIndex;
                    listBoxCarTypeAttributes.SetSelected(r, true);
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            if (listBoxPath.Items.Contains(listBoxLocations.SelectedItem))
            {
                MessageBox.Show("Path already Contains Location");
            }
            else
            {
                if (listBoxPath.SelectedIndex < 0)
                {
                    listBoxPath.Items.Add(listBoxLocations.SelectedItem);
                }
                else
                {
                    listBoxPath.Items.Insert(listBoxPath.SelectedIndex + 1, listBoxLocations.SelectedItem);
                }
            }
        }

        private void buttonRemovePath_Click(object sender, EventArgs e)
        {
            int i = listBoxPath.SelectedIndex;
            listBoxPath.Items.Remove(listBoxPath.SelectedItem);
            if (listBoxPath.Items.Count != 0)
            {
                if (i == 0)
                {
                    listBoxPath.SelectedIndex = 0;
                }
                else
                {
                    listBoxPath.SelectedIndex = i - 1;
                }
            }
        }

        private void checkBoxIsLiveStock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsLiveStock.Checked)
            {
                checkBoxIsPerishable.Checked = false;
                checkBoxPreIce.Enabled = false;
                checkBoxInitialIce.Enabled = false;
            }
            else
            {
                
            }
        }

        private void checkBoxIsPerishable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsPerishable.Checked)
            {
                checkBoxIsLiveStock.Checked = false;
                checkBoxInitialIce.Enabled = true;
                checkBoxPreIce.Enabled = true;
            }
            else
            {
                checkBoxPreIce.Enabled = false;
                checkBoxInitialIce.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int nextWaybillID = 0;
            if(comboBoxNextWaybill.SelectedValue != null)
            {
                nextWaybillID = (int)comboBoxNextWaybill.SelectedValue;
            }
            string displayText = comboBoxShipper.Text + " -> " + comboBoxConsignee.Text + " - " + textBoxDescOfArticles.Text.Trim();
            CoreWebService.BillOfLadingResponse response = client.addBillOfLading((int)comboBoxConsignee.SelectedValue, (int)comboBoxShipper.SelectedValue, (int)comboBoxRequestedCarType.SelectedValue, (int)numericUpDownRequestedLength.Value, (int)numericUpDownCapacityTons.Value, textBoxNoPkgs.Text, textBoxDescOfArticles.Text, checkBoxIsPerishable.Checked, checkBoxPreIce.Checked, checkBoxInitialIce.Checked, 0, false, checkBoxIsLiveStock.Checked, checkBoxReverseRoute.Checked, checkBoxReturnEmpty.Checked, checkBoxNextWaybill.Checked, nextWaybillID, (decimal)numericUpDownCarsPerDay.Value, (int)numericUpDownUnloadTime.Value, (int)numericUpDownLoadTime.Value, displayText, true);

            if (response.Status == 0)
            {              
                CoreWebService.BillOfLadingPathResponse path = new CoreWebService.BillOfLadingPathResponse();
                for (int i = 0; i < listBoxPath.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        CoreWebService.Location item = (CoreWebService.Location)listBoxLocations.Items[i];
                        path = client.addBillOfLadingPath(response.Data.ID, item.ID, 0, true);
                    }
                    else
                    {
                        CoreWebService.Location item = (CoreWebService.Location)listBoxLocations.Items[i];
                        int previousPathID = path.Data.ID;
                        path = client.addBillOfLadingPath(response.Data.ID, item.ID, 0, false);
                        client.updateBillOfLadingPath(previousPathID, response.Data.ID, path.Data.ID);
                    }
                }

                foreach (var i in listBoxCarTypeAttributes.SelectedIndices)
                {
                    CoreWebService.CarTypeAttribute item = (CoreWebService.CarTypeAttribute)listBoxCarTypeAttributes.Items[(int)i];
                    CoreWebService.BillOfLadingCarTypeAttributesResponse rsResponse = client.addBillOfLadingCartypeAttribute(response.Data.ID, item.ID);
                }

                CoreWebService.BillOfLadingListResponse waybillTemplates = client.listBillOfLading(textBoxSearch.Text);
                if (waybillTemplates.Status == 0)
                {
                    listBoxBillOfLading.DisplayMember = "displayText";
                    listBoxBillOfLading.ValueMember = "ID";
                    listBoxBillOfLading.DataSource = waybillTemplates.Data;
                }

                listBoxBillOfLading.SelectedValue = response.Data.ID;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {   
            int nextWaybillID = 0;
            if (comboBoxNextWaybill.SelectedValue != null)
            {
                nextWaybillID = (int)comboBoxNextWaybill.SelectedValue;
            }
            string displayText = comboBoxShipper.Text + " -> " + comboBoxConsignee.Text + " - " + textBoxDescOfArticles.Text.Trim();
            CoreWebService.BillOfLadingResponse response = client.updateBillOfLading((int)listBoxBillOfLading.SelectedValue, (int)comboBoxConsignee.SelectedValue, (int)comboBoxShipper.SelectedValue, (int)comboBoxRequestedCarType.SelectedValue, (int)numericUpDownRequestedLength.Value, (int)numericUpDownCapacityTons.Value, textBoxNoPkgs.Text, textBoxDescOfArticles.Text, checkBoxIsPerishable.Checked, checkBoxPreIce.Checked, checkBoxInitialIce.Checked, 0, false, checkBoxIsLiveStock.Checked, checkBoxReverseRoute.Checked, checkBoxReturnEmpty.Checked, checkBoxNextWaybill.Checked, nextWaybillID, (decimal)numericUpDownCarsPerDay.Value, (int)numericUpDownUnloadTime.Value, (int)numericUpDownLoadTime.Value, displayText, true);

            if (response.Status == 0)
            {               
                CoreWebService.BillOfLadingPathResponse path = new CoreWebService.BillOfLadingPathResponse();
                client.deleteBillOfLadingPath(response.Data.ID);
                for (int i = 0; i < listBoxPath.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        CoreWebService.Location item = (CoreWebService.Location)listBoxLocations.Items[i];
                        path = client.addBillOfLadingPath(response.Data.ID, item.ID, 0, true);
                    }
                    else
                    {
                        CoreWebService.Location item = (CoreWebService.Location)listBoxLocations.Items[i];
                        int previousPathID = path.Data.ID;
                        path = client.addBillOfLadingPath(response.Data.ID, item.ID, 0, false);
                        client.updateBillOfLadingPath(previousPathID, response.Data.ID, path.Data.ID);
                    }
                }

                client.deleteBillOfLadingCartypeAttribute((int)listBoxBillOfLading.SelectedValue);
                foreach (var i in listBoxCarTypeAttributes.SelectedIndices)
                {
                    CoreWebService.CarTypeAttribute item = (CoreWebService.CarTypeAttribute)listBoxCarTypeAttributes.Items[(int)i];
                    CoreWebService.BillOfLadingCarTypeAttributesResponse rsResponse = client.addBillOfLadingCartypeAttribute(response.Data.ID, item.ID);
                }

                CoreWebService.BillOfLadingListResponse waybillTemplates = client.listBillOfLading(textBoxSearch.Text);
                if (waybillTemplates.Status == 0)
                {
                    listBoxBillOfLading.DisplayMember = "displayText";
                    listBoxBillOfLading.ValueMember = "ID";
                    listBoxBillOfLading.DataSource = waybillTemplates.Data;
                }

                listBoxBillOfLading.SelectedValue = response.Data.ID;
            }
        }

        private void listBoxBillOfLading_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoreWebService.BillOfLadingResponse response = client.getBillOfLading((int)listBoxBillOfLading.SelectedValue);

            if(response.Status == 0)
            {
                comboBoxConsignee.SelectedValue = response.Data.consigneeID;
                comboBoxShipper.SelectedValue = response.Data.shipperID;
                comboBoxRequestedCarType.SelectedValue = response.Data.carTypeRequestedID;
                comboBoxRequestedCarType_SelectedIndexChanged(this, null);
                textBoxNoPkgs.Text = response.Data.noPackages;
                textBoxDescOfArticles.Text = response.Data.descriptionOfArticles;
                numericUpDownRequestedLength.Value = (decimal)response.Data.carLengthRequested;
                numericUpDownCapacityTons.Value = (decimal)response.Data.carCapacityRequested;
                checkBoxIsPerishable.Checked = (bool)response.Data.isPerishable;
                checkBoxIsLiveStock.Checked = (bool)response.Data.isLiveStock;
                checkBoxPreIce.Checked = (bool)response.Data.isPreIce;
                checkBoxInitialIce.Checked = (bool)response.Data.isInitialIce;
                checkBoxReverseRoute.Checked = (bool)response.Data.isReverseRoute;
                checkBoxReturnEmpty.Checked = (bool)response.Data.isReturnEmpty;
                checkBoxNextWaybill.Checked = (bool)response.Data.isNextBillOfLading;
                numericUpDownCarsPerDay.Value = (decimal)response.Data.requestedCarsPerDay;
                numericUpDownLoadTime.Value = (decimal)response.Data.timeToLoad;
                numericUpDownUnloadTime.Value = (decimal)response.Data.timeToUnload;
                comboBoxNextWaybill.SelectedValue = (int)response.Data.nextBillOfLadingID;

                CoreWebService.BillOfLadingPathListResponse path = client.listBillOfLadingPath((int)listBoxBillOfLading.SelectedValue);
                listBoxPath.Items.Clear();

                if (path.Status == 0)
                {              
                    for (int i = 0; i < path.Data.Length; i++)
                    {                       
                        listBoxPath.Items.Add(client.getLocation((int)path.Data[i].locationID).Data);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = listBoxBillOfLading.SelectedIndex;

            CoreWebService.BillOfLadingCarTypeAttributesListResponse carTypeAttribute = client.deleteBillOfLadingCartypeAttribute((int)listBoxBillOfLading.SelectedValue);
            if(carTypeAttribute.Status != 0)
            {
                MessageBox.Show(carTypeAttribute.Message);
            }

            CoreWebService.BillOfLadingPathListResponse path = client.deleteBillOfLadingPath((int)listBoxBillOfLading.SelectedValue);
            if(path.Status != 0)
            {
                MessageBox.Show(path.Message);
            }

            CoreWebService.BillOfLadingResponse waybillTemplate = client.deleteBillOfLading((int)listBoxBillOfLading.SelectedValue);
            if(waybillTemplate.Status != 0)
            {
                MessageBox.Show(waybillTemplate.Message);
            }

            listBoxBillOfLading.SelectedIndex = i - 1;
            listBoxBillOfLading_SelectedIndexChanged(this, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
