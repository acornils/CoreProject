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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarType carType = new CarType();
            carType.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            clock.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            SwitchList switchList = new SwitchList();
            switchList.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            SetupSwitchList setupSwitchList = new SetupSwitchList();
            setupSwitchList.Show();
        }

        private void buttonCarType_Click(object sender, EventArgs e)
        {
            CarType carType = new CarType();
            carType.Show();
        }

        private void buttonRollingStock_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void buttonClock_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            clock.Show();
        }

        private void buttonLocations_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
        }

        private void buttonSwitchList_Click(object sender, EventArgs e)
        {
            SwitchList switchList = new SwitchList();
            switchList.Show();
        }

        private void buttonSwitchListDesigner_Click(object sender, EventArgs e)
        {
            SetupSwitchList setupSwitchList = new SetupSwitchList();
            setupSwitchList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrCodes arrCodes = new ArrCodes();
            arrCodes.Show();
        }

        private void buttonTrains_Click(object sender, EventArgs e)
        {

        }

        private void buttonRollingStock_Click_1(object sender, EventArgs e)
        {
            RollingStock rollingStock = new RollingStock();
            rollingStock.Show();
        }

        private void buttonConsigneeShipper_Click(object sender, EventArgs e)
        {
            ConsigneeShipper consigneeShipper = new ConsigneeShipper();
            consigneeShipper.Show();
        }

        private void buttonWaybillTemplates_Click(object sender, EventArgs e)
        {
            BillOfLading waybillTemplates = new BillOfLading();
            waybillTemplates.Show();
        }

        private void buttonWaybill_Click(object sender, EventArgs e)
        {
            Waybill waybill = new Waybill();
            waybill.Show();
        }
    }
}