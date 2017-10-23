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
    public partial class Routes : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Path> paths = new List<CoreWebService.Path>();
        List<CoreWebService.Location> locations;
        List<CoreWebService.Location> newLocations = new List<CoreWebService.Location>();
        List<CoreWebService.Route> routes;

        public Routes()
        {
            InitializeComponent();
        }

        private void Routes_Load(object sender, EventArgs e)
        {
            loadFormData();
        }

        private void loadFormData()
        {
            locations = client.listLocations().ToList<CoreWebService.Location>().OrderBy(x => x.name).ToList();
            routes = client.getAllRoutes().ToList<CoreWebService.Route>();

            refreshLocations();

            //listBoxRoutes.DataSource = routes;
            //listBoxRoutes.DisplayMember = "name";
            //listBoxRoutes.ValueMember = "ID";
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            CoreWebService.Path path = new CoreWebService.Path();
            CoreWebService.Location location = client.getLocation(Convert.ToInt32(listBoxLocations.SelectedValue));
            path.RouteID = 0;
            path.locationID = location.ID;
            path.nextLocationID = 0;
            path.symbol = textBoxSymbol.Text;
            path.defaultStatus = "";
            if(listBoxNewRoute.Items.Count == 0)
            {
                path.isStart = true;
            }
            else
            {
                path.isStart = false;
            }
            path.isEnd = false;

            int i = listBoxNewRoute.SelectedIndex + 1;

            if (paths.Count == 0)
            {
                paths.Add(path);
                newLocations.Add(location);
            }
            else
            {
                paths.Insert(listBoxNewRoute.SelectedIndex + 1, path);
                newLocations.Insert(listBoxNewRoute.SelectedIndex + 1, location);
            }

            try
            {
                locations.RemoveAt(listBoxLocations.SelectedIndex);
                refreshNewRoute(i);
                refreshLocations();
            }
            catch(ArgumentOutOfRangeException)
            {
                paths.RemoveAt(paths.Count - 1);
                newLocations.RemoveAt(newLocations.Count - 1);
            }


        }

        private void refreshLocations()
        {
            
            listBoxLocations.DataSource = null;
            listBoxLocations.DataSource = locations.OrderBy(x => x.name).ToList();
            listBoxLocations.DisplayMember = "name";
            listBoxLocations.ValueMember = "ID";
        }

        private void refreshNewRoute(int index)
        {
            listBoxNewRoute.DataSource = null;
            listBoxNewRoute.DataSource = newLocations;
            listBoxNewRoute.DisplayMember = "name";
            listBoxNewRoute.ValueMember = "ID";
            listBoxNewRoute.SelectedIndex = index;
        }

        private void buttonRemoveLocation_Click(object sender, EventArgs e)
        {
            int i = listBoxNewRoute.SelectedIndex;

            try
            {
                locations.Add(newLocations[i]);
                newLocations.RemoveAt(i);
                refreshLocations();
                refreshNewRoute(i - 1);
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }
    }

}
