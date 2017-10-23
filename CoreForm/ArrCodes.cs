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
    public partial class ArrCodes : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.ARRCode> arrCodes = new List<CoreWebService.ARRCode>();

        public ArrCodes()
        {
            InitializeComponent();
        }

        private void ArrCodes_Load(object sender, EventArgs e)
        {
            refreshData();                        
        }

        private void refreshData()
        {
            CoreWebService.ArrCodeListResponse response = client.listAllArrCode(textBoxFilter.Text);
            
            if (response.Status == 0)
            {
                arrCodes = response.Data.ToList<CoreWebService.ARRCode>();
                listBox1.DataSource = arrCodes;
                listBox1.DisplayMember = "Carrier";
                listBox1.ValueMember = "ID";
            }
            else
            {

            }            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeResponse response = new CoreWebService.ArrCodeResponse();
            response = client.addArrCode(textBoxNo.Text, textBoxCarrier.Text, textBoxAbbr.Text);
            if(response.Status == 0)
            {
                refreshData();
                listBox1.SelectedIndex = arrCodes.FindIndex(x => x.ID == response.Data.ID);
            }
            else if(response.Status == 1)
            {
                MessageBox.Show(response.Message);
            }
            else if(response.Status == 2)
            {
                MessageBox.Show(response.Message);
            }
            else
            {

            }

            textBoxNo.Focus();
            textBoxNo.SelectAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFields();
        }

        private void loadFields()
        {
            try
            {
                CoreWebService.ArrCodeResponse response = client.getArrCode(Convert.ToInt32(listBox1.SelectedValue));
                
                if (response.Status == 0)
                {
                    CoreWebService.ARRCode arrCode = response.Data;
                    textBoxNo.Text = arrCode.No;
                    textBoxCarrier.Text = arrCode.Carrier;
                    textBoxAbbr.Text = arrCode.Abbr;
                }
                else
                {

                }
            }
            catch(InvalidCastException e)
            {

            }
   
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeResponse response = new CoreWebService.ArrCodeResponse();
            response = client.updateArrCode((Int32)listBox1.SelectedValue, textBoxNo.Text, textBoxCarrier.Text, textBoxAbbr.Text);

            if (response.Status == 0)
            {
                refreshData();
                listBox1.SelectedIndex = arrCodes.FindIndex(x => x.ID == response.Data.ID);
            }
            else if (response.Status == 1)
            {
                MessageBox.Show(response.Message);
            }
            else if (response.Status == 2)
            {
                MessageBox.Show(response.Message);
            }
            else
            {

            }

            textBoxNo.Focus();
            textBoxNo.SelectAll();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CoreWebService.ArrCodeResponse response = new CoreWebService.ArrCodeResponse();
            response = client.deleteArrCode((Int32)listBox1.SelectedValue);
            int i = listBox1.SelectedIndex;

            if (response.Status == 0)
            {
                refreshData();
                listBox1.SelectedIndex = i - 1;
            }
            else if (response.Status == 1)
            {
                MessageBox.Show(response.Message);
            }
            else if (response.Status == 2)
            {
                MessageBox.Show(response.Message);
            }
            else
            {

            }

            textBoxNo.Focus();
            textBoxNo.SelectAll();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
