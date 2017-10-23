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
    public partial class RollingStock : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public RollingStock()
        {
            InitializeComponent();
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private void RollingStock_Load(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeListResponse arrCodes = client.listAllArrCode("");
            comboBoxArrCode.DisplayMember = "Carrier";
            comboBoxArrCode.ValueMember = "ID";
            comboBoxArrCode.DataSource = arrCodes.Data;

            CoreWebService.CarTypeListResponse carType = client.listCarTypes();
            comboBoxCarType.DisplayMember = "shortName";
            comboBoxCarType.ValueMember = "ID";
            comboBoxCarType.DataSource = carType.Data;

            CoreWebService.RollingStockListResponse rollingStock = client.listAllRollingStock("");
            listBoxCars.DisplayMember = "displayText";
            listBoxCars.ValueMember = "ID";
            listBoxCars.DataSource = rollingStock.Data;
        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            CoreWebService.RollingStockResponse rollingStock = client.getRollingStock((int)listBoxCars.SelectedValue);

            if (rollingStock.Status == 0)
            {
                comboBoxArrCode.SelectedValue = rollingStock.Data.arrCodeID;
                comboBoxCarType.SelectedValue = rollingStock.Data.carTypeID;

                textBoxRoadNumber.Text = rollingStock.Data.roadNumber;
                numericUpDownLength.Value = (decimal)rollingStock.Data.length;
                numericUpDownCapacityTons.Value = (decimal)rollingStock.Data.capacityTonnage;
                textBoxTrain.Text = rollingStock.Data.trainID.ToString();

                if (rollingStock.Data.locationID != null)
                {
                    CoreWebService.LocationResponse location = client.getLocation((int)rollingStock.Data.locationID);

                    if (location.Status == 0)
                    {
                        textBoxLocation.Text = location.Data.name;
                    }
                }

                if (rollingStock.Data.nextRS != null)
                {
                    CoreWebService.RollingStockResponse nextCar = client.getRollingStock((int)rollingStock.Data.nextRS);

                    if (nextCar.Status == 0)
                    {
                        textBoxNextCar.Text = nextCar.Data.displayText;
                    }
                }

                textBoxRFID.Text = rollingStock.Data.RFID;

                if (rollingStock.Data.isFirst != null)
                {
                    checkBoxIsFirstCar.Checked = (bool)rollingStock.Data.isFirst;
                }

                if (rollingStock.Data.isLast != null)
                {
                    checkBoxIsLastCar.Checked = (bool)rollingStock.Data.isLast;
                }
            }

            comboBoxCarType_SelectedIndexChanged(this, null);
        }

        private void comboBoxArrCode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            CoreWebService.RollingStockListResponse rollingStock = client.listAllRollingStock(textBoxSearch.Text);
            listBoxCars.DisplayMember = "displayText";
            listBoxCars.ValueMember = "ID";
            listBoxCars.DataSource = rollingStock.Data;
        }

        private void comboBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoreWebService.CarTypeAttributeListResponse carTypeAttributes = client.listCarTypeAttributes((int)comboBoxCarType.SelectedValue);
            listBoxCarTypeAttributes.DisplayMember = "attribute";
            listBoxCarTypeAttributes.ValueMember = "ID";
            listBoxCarTypeAttributes.DataSource = carTypeAttributes.Data;
            listBoxCarTypeAttributes.ClearSelected();

            try
            {
                CoreWebService.RollingStockAttributeListResponse rollingStockAttribute = client.listRollingStockAttribute((int)listBoxCars.SelectedValue);

                for (int i = 0; i < rollingStockAttribute.Data.Count; i++)
                {
                    listBoxCarTypeAttributes.SelectedValue = rollingStockAttribute.Data[i].carTypeAttrID;
                    int r = listBoxCarTypeAttributes.SelectedIndex;
                    listBoxCarTypeAttributes.SetSelected(r, true);
                }
            }
            catch(NullReferenceException)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeResponse arrCode = client.getArrCode((int)comboBoxArrCode.SelectedValue);
            string displayText = arrCode.Data.Abbr + " " + textBoxRoadNumber.Text.Trim();

            CoreWebService.RollingStockResponse response = client.addRollingStock(textBoxRoadNumber.Text, (int)comboBoxArrCode.SelectedValue, (int)numericUpDownLength.Value, (int)numericUpDownCapacityTons.Value, (int)comboBoxCarType.SelectedValue, textBoxRFID.Text, displayText);
            
            if(response.Status == 0)
            {
                foreach (var i in listBoxCarTypeAttributes.SelectedIndices)
                {
                    CoreWebService.CarTypeAttribute item = (CoreWebService.CarTypeAttribute)listBoxCarTypeAttributes.Items[(int)i];
                    CoreWebService.RollingStockAttributeResponse rsResponse = client.addRollingStockAttribute(response.Data.ID, item.ID);
                }

                CoreWebService.RollingStockListResponse rollingStock = client.listAllRollingStock("");
                listBoxCars.DisplayMember = "displayText";
                listBoxCars.ValueMember = "ID";
                listBoxCars.DataSource = rollingStock.Data;

                listBoxCars.SelectedValue = response.Data.ID;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeResponse arrCode = client.getArrCode((int)comboBoxArrCode.SelectedValue);
            string displayText = arrCode.Data.Abbr + " " + textBoxRoadNumber.Text.Trim();

            CoreWebService.RollingStockResponse response = client.updateRollingstock((int)listBoxCars.SelectedValue, textBoxRoadNumber.Text, (int)comboBoxArrCode.SelectedValue, (int)numericUpDownLength.Value, (int)numericUpDownCapacityTons.Value, (int)comboBoxCarType.SelectedValue, textBoxRFID.Text, displayText);

            if (response.Status == 0)
            {
                CoreWebService.RollingStockAttributeListResponse rsDeleteResponse = client.deleteAllRollingStockAttribute(response.Data.ID);

                foreach (var i in listBoxCarTypeAttributes.SelectedIndices)
                {
                    CoreWebService.CarTypeAttribute item = (CoreWebService.CarTypeAttribute)listBoxCarTypeAttributes.Items[(int)i];
                    CoreWebService.RollingStockAttributeResponse rsResponse = client.addRollingStockAttribute(response.Data.ID, item.ID);
                }

                CoreWebService.RollingStockListResponse rollingStock = client.listAllRollingStock("");
                listBoxCars.DisplayMember = "displayText";
                listBoxCars.ValueMember = "ID";
                listBoxCars.DataSource = rollingStock.Data;

                listBoxCars.SelectedValue = response.Data.ID;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = listBoxCars.SelectedIndex;

            CoreWebService.RollingStockResponse response = client.deleteRollingStock((int)listBoxCars.SelectedValue);

            if(response.Status != 0)
            {
                MessageBox.Show(response.Message);
            }

            CoreWebService.RollingStockListResponse rollingStock = client.listAllRollingStock("");
            listBoxCars.DisplayMember = "displayText";
            listBoxCars.ValueMember = "ID";
            listBoxCars.DataSource = rollingStock.Data;

            listBoxCars.SelectedIndex = i - 1;
        }

    }

}
