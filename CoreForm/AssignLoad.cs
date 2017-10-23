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
    public partial class AssignLoad : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.load> loads;
        List<CoreWebService.RollingStock> rollingStock;

        public AssignLoad()
        {
            InitializeComponent();
        }

        private void AssignLoad_Load(object sender, EventArgs e)
        {
            loads = client.getAllLoads().ToList<CoreWebService.load>();
            comboBoxLoads.DataSource = loads;
            comboBoxLoads.DisplayMember = "name";
            comboBoxLoads.ValueMember = "ID";

            rollingStock = client.listAllCars("Car").ToList<CoreWebService.RollingStock>();
            comboBoxCars.DataSource = rollingStock;
            comboBoxCars.DisplayMember = "roadNumber";
            comboBoxCars.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loadID = loads[comboBoxLoads.SelectedIndex].ID;
            CoreWebService.RollingStock car = rollingStock[comboBoxCars.SelectedIndex];
            if (client.isloadAllowedByCarType(loadID, Convert.ToInt32(car.carTypeID)))
            {
                client.assignCarToLoad(car.ID, loadID);
                Close();
            }
            else
            {
                MessageBox.Show("This load is not allowed for this car type.");
            }
            
        }
    }
}
