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
    public partial class Waybill : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();

        public Waybill()
        {
            InitializeComponent();
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private void Waybill_Load(object sender, EventArgs e)
        {
            CoreWebService.BillOfLadingListResponse waybillTemplates = client.listBillOfLading("");
            if(waybillTemplates.Status == 0)
            {
                listBoxWaybillTemplates.DisplayMember = "displayText";
                listBoxWaybillTemplates.ValueMember = "ID";
                listBoxWaybillTemplates.DataSource = waybillTemplates.Data;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            CoreWebService.BillOfLadingListResponse waybillTemplates = client.listBillOfLading(textBoxSearch.Text);
            if (waybillTemplates.Status == 0)
            {
                listBoxWaybillTemplates.DisplayMember = "displayText";
                listBoxWaybillTemplates.ValueMember = "ID";
                listBoxWaybillTemplates.DataSource = waybillTemplates.Data;
            }
        }

        private void checkBoxAssignCar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAssignCar.Checked == true)
            {
                comboBoxRollingStock.Enabled = true;
            }
            else
            {
                comboBoxRollingStock.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rollingStockID = 0;

            if(checkBoxAssignCar.Checked == true)
            {

            }
        }

        private void listBoxWaybillTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoreWebService.RollingStockListResponse rollingStock = client.listRollingStockForWaybill((int)listBoxWaybillTemplates.SelectedValue);
            if (rollingStock.Status == 0)
            {
                comboBoxRollingStock.DisplayMember = "displayText";
                comboBoxRollingStock.SelectedValue = "ID";
                comboBoxRollingStock.DataSource = rollingStock.Data;
            }
        }
    }
}
