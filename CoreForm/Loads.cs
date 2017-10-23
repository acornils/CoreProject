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
    public partial class Loads : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Route> routes;
        List<CoreWebService.load> loads;
        List<CoreWebService.CarType> carTypes;

        private void Loads_Load(object sender, EventArgs e)
        {
            routes = client.getAllRoutes().OrderBy(x => x.name).ToList();
            routes.Insert(0, new CoreWebService.Route());
            comboBoxRoute.DataSource = routes;
            comboBoxRoute.DisplayMember = "name";
            comboBoxRoute.ValueMember = "ID";
            comboBoxRoute.SelectedIndex = 1;

            listBoxAllowedCarTypes.DataSource = carTypes;

            refreshLoadList();
            refreshCarTypesList();
        }
        
        public Loads()
        {
            InitializeComponent();
        }

        private void refreshCarTypesList()
        {
            carTypes = client.listCarTypes().ToList<CoreWebService.CarType>();
            listBoxAllowedCarTypes.DataSource = carTypes;
            listBoxAllowedCarTypes.DisplayMember = "shortName";
            listBoxAllowedCarTypes.ValueMember = "ID";
            listBoxAllowedCarTypes.SelectedIndices.Clear();
        }

        private void refreshLoadList()
        {
            loads = client.getAllLoads().ToList<CoreWebService.load>();
            listBoxLoads.DataSource = loads;
            listBoxLoads.DisplayMember = "name";
            listBoxLoads.ValueMember = "ID";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.load load = client.addLoad(textBoxNewLoad.Text, Convert.ToInt32(comboBoxRoute.SelectedValue));
            client.clearLoadCarTypes(load.ID);

            for (int i = 0; i < listBoxAllowedCarTypes.SelectedIndices.Count; i++)
            {
                client.addCarTypeRestriction(load.ID, carTypes[listBoxAllowedCarTypes.SelectedIndices[i]].ID);
            }

            refreshLoadList();
        }

        private void listBoxLoads_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoreWebService.load load = client.getLoad(loads[listBoxLoads.SelectedIndex].ID);
            textBoxNewLoad.Text = load.name;
            comboBoxRoute.SelectedIndex = routes.FindIndex(x => x.ID == load.RouteID);


            listBoxAllowedCarTypes.ClearSelected();
            List<CoreWebService.loadAllowedCarType> loadAllowedCarTypes = client.listLoadCarAllowedCarTypes(load.ID).ToList<CoreWebService.loadAllowedCarType>();
            for (int i = 0; loadAllowedCarTypes.Count > i; i++ )
            {
                listBoxAllowedCarTypes.SetSelected(carTypes.FindIndex(x => x.ID == loadAllowedCarTypes[i].carTypeID), true);                
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoreWebService.load load = client.getLoad(loads[listBoxLoads.SelectedIndex].ID);
            load = client.updateLoad(load.ID, textBoxNewLoad.Text, Convert.ToInt32(comboBoxRoute.SelectedValue));
            client.clearLoadCarTypes(load.ID);

            for (int i = 0; i < listBoxAllowedCarTypes.SelectedIndices.Count; i++)
            {
                client.addCarTypeRestriction(load.ID, carTypes[listBoxAllowedCarTypes.SelectedIndices[i]].ID);
            }

            refreshLoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CoreWebService.load load = client.getLoad(loads[listBoxLoads.SelectedIndex].ID);
            client.clearLoadCarTypes(load.ID);
            client.deleteLoad(load.ID);

            refreshLoadList();
        }


    }
}
