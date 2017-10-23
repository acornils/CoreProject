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
    public partial class Trains : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Train> trains = new List<CoreWebService.Train>();

        public Trains()
        {
            InitializeComponent();
        }

        private void Trains_Load(object sender, EventArgs e)
        {
            loadTrains();
        }

        private void loadTrains()
        {
            trains = client.listAllTrains().ToList<CoreWebService.Train>();
            listBoxTrains.DataSource = trains;
            listBoxTrains.DisplayMember = "number";
            listBoxTrains.ValueMember = "ID";
        }

        private void listBoxTrains_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTrainNumber.Text = client.getTrain(Convert.ToInt32(listBoxTrains.SelectedValue)).number.ToString();
            }
            catch(InvalidCastException)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            client.addTrain(textBoxTrainNumber.Text);
            loadTrains();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            client.deleteTrain(Convert.ToInt32(listBoxTrains.SelectedValue));
            loadTrains();
        }


    }
}
