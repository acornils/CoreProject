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
    public partial class CarType : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.CarType> carType;

        public CarType()
        {
            InitializeComponent();
        }

        private void CarType_Load(object sender, EventArgs e)
        {
            refreshListBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxShortName.Text != null && textBoxShortName.Text.Length > 0)
            {
                CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
                client.addCarType(textBoxShortName.Text, textBoxLongName.Text, textBoxDescription.Text);
                refreshListBox();
            }
        }

        private void listBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxShortName.Text = carType[listBoxCarType.SelectedIndex].shortName;
            textBoxLongName.Text = carType[listBoxCarType.SelectedIndex].longName;
            textBoxDescription.Text = carType[listBoxCarType.SelectedIndex].description;

            refreshAttributeListBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            client.updateCarType(carType[listBoxCarType.SelectedIndex].ID, textBoxShortName.Text, textBoxLongName.Text, textBoxDescription.Text);
            refreshListBox();
        }

        private void refreshListBox()
        {
            CoreWebService.CarTypeListResponse response = client.listCarTypes();
            carType = response.Data.ToList<CoreWebService.CarType>();
            listBoxCarType.DataSource = carType;
            listBoxCarType.DisplayMember = "shortName";
            listBoxCarType.ValueMember = "ID";

            refreshAttributeListBox();
        }

        private void refreshAttributeListBox()
        {
            try
            {
                CoreWebService.CarTypeAttributeListResponse response = client.listCarTypeAttributes(Convert.ToInt32(listBoxCarType.SelectedValue));
                if (response.Status == 0)
                {
                    listBoxAttributes.DataSource = response.Data;
                    listBoxAttributes.DisplayMember = "attribute";
                    listBoxAttributes.ValueMember = "ID";
                }
                else
                {

                }
            }
            catch(InvalidCastException e)
            {

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteCarType(carType[listBoxCarType.SelectedIndex].ID);
                refreshListBox();
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxAttribute.Text != null || textBoxAttribute.Text.Length > 0)
            {
                CoreWebService.CarTypeAttributeResponse response = client.addCarTypeAttribute(Convert.ToInt32(listBoxCarType.SelectedValue), textBoxAttribute.Text);

                if (response.Status == 0)
                {
                    refreshAttributeListBox();
                }
                else if(response.Status == 2)
                {
                    MessageBox.Show(response.Message);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            CoreWebService.CarTypeAttributeResponse response = client.deleteCarTypeAttribute(Convert.ToInt32(listBoxAttributes.SelectedValue));

            if(response.Status == 0)
            {
                refreshAttributeListBox();
            }
        }
    }
}
