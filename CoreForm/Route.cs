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
    public partial class Route : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Route> routes;
        List<CoreWebService.Location> locations = new List<CoreWebService.Location>();
        List<CoreWebService.Path> path;

        private NewRoute newRoute = new NewRoute();

        public Route()
        {
            InitializeComponent();
            newRoute.RouteAdded += new EventHandler(this.Route_Added);
        }

        private void Route_Load(object sender, EventArgs e)
        {
            refreshRouteList();
            refreshLocationList();
        }

        private void Route_Added(object sender, EventArgs e)
        {
            refreshRouteList();
        }

        private void refreshRouteList ()
        {
            routes = client.getAllRoutes().ToList<CoreWebService.Route>();
            listBoxRoutes.DataSource = null;
            listBoxRoutes.DataSource = routes;
            listBoxRoutes.DisplayMember = "name";
            listBoxRoutes.ValueMember = "ID";
        }

        private void refreshLocationList()
        {
            locations = client.listLocations().ToList<CoreWebService.Location>();
            listBoxLocations.DataSource = null;
            listBoxLocations.DataSource = locations;
            listBoxLocations.DisplayMember = "name";
            listBoxLocations.ValueMember = "ID";
        }

        private void refreshPathList(int lastIndex)
        {
            path = client.getPath(routes[listBoxRoutes.SelectedIndex].ID).ToList<CoreWebService.Path>();            
            listBoxPath.DataSource = null;
            listBoxPath.DataSource = path;
            listBoxPath.DisplayMember = "displayText";
            listBoxPath.ValueMember = "ID";
            try
            {
                listBoxPath.SelectedIndex = lastIndex;
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void buttonNewRoute_Click(object sender, EventArgs e)
        {
            newRoute.Show();
        }

        private void listBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRouteName.Text = routes[listBoxRoutes.SelectedIndex].name;
                textBoxRouteDescription.Text = routes[listBoxRoutes.SelectedIndex].description;
                checkBoxIsCaptive.Checked = (bool)routes[listBoxRoutes.SelectedIndex].isLoop;
                refreshPathList(0);
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Boolean isSuccess = client.insertPathElement(routes[listBoxRoutes.SelectedIndex].ID, locations[listBoxLocations.SelectedIndex].ID, textBoxSymbol.Text, textBoxStatus.Text, listBoxPath.SelectedIndex);
            if (isSuccess)
            {
                refreshPathList(listBoxPath.SelectedIndex + 1);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBoxSymbol.Text = path[listBoxPath.SelectedIndex].symbol;
            textBoxStatus.Text = path[listBoxPath.SelectedIndex].defaultStatus;
            Boolean isSuccess = client.deletePathElement(path[listBoxPath.SelectedIndex].ID);
            if (isSuccess)
            {
                refreshPathList(listBoxPath.SelectedIndex - 1);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            client.updateRoute(Convert.ToInt32(listBoxRoutes.SelectedValue), routes[listBoxRoutes.SelectedIndex].name, routes[listBoxRoutes.SelectedIndex].description, checkBoxIsCaptive.Checked);
            refreshRouteList();
        }

    }
}
