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
    public partial class Cars : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public Cars()
        {
            InitializeComponent();
        }

        private void loadArrComboBox()
        {
            CoreWebService.ArrCodeListResponse response = client.listAllArrCode("");

            if (response.Status == 0)
            {                
                comboBoxArrCode.DataSource = response.Data;
                comboBoxArrCode.DisplayMember = "Carrier";
                comboBoxArrCode.SelectedValue = "ID";
            }
        }

        private void loadCarTypeComboBox()
        {
            CoreWebService.CarTypeListResponse response = client.listCarTypes();

            if (response.Status == 0)
            {                
                comboBoxCarType.DataSource = response.Data;
                comboBoxCarType.DisplayMember = "shortName";
                comboBoxCarType.SelectedValue = "ID";
            }
        }

        private void loadListBoxCars(string search)
        {
            CoreWebService.RollingStockListResponse response = client.listAllRollingStock(search);

            if(response.Status == 0)
            {                
                listBoxCars.DataSource = response.Data;
                listBoxCars.DisplayMember = "displayText";
                listBoxCars.ValueMember = "ID";
            }
        }
    }
}
