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
    public partial class NewRoute : Form
    {
        public event EventHandler RouteAdded;
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        List<CoreWebService.Route> routes;

        public NewRoute()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CoreWebService.Route route = client.addRoute(textBoxName.Text, textBoxDescription.Text, checkBoxIsLoop.Checked);
            if(comboBoxTemplate.SelectedIndex > 0)
            {
                client.duplicatePath(Convert.ToInt32(comboBoxTemplate.SelectedValue), route.ID);
            }
            this.RouteAdded(sender, e);
            this.Close();
        }

        private void NewRoute_Load(object sender, EventArgs e)
        {
            routes = client.getAllRoutes().OrderBy(x => x.name).ToList();
            routes.Insert(0, new CoreWebService.Route());
            comboBoxTemplate.DataSource = routes;
            comboBoxTemplate.DisplayMember = "name";
            comboBoxTemplate.ValueMember = "ID";
        }


    }
}
