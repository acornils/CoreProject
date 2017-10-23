using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoreForm
{
    public partial class SetupSwitchList : Form
    {
        CoreWebService.CoreSoapClient client = new CoreWebService.CoreSoapClient();
        CoreWebService.SwitchListsLayout layout = new CoreWebService.SwitchListsLayout();
        Bitmap bitmap = null;

        public SetupSwitchList()
        {
            InitializeComponent();
            SetupSwitchList_Load(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            layoutPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Jpeg Files (.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;            

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                openSwitchListImage(openFileDialog1.FileName);
            }
        }

        private void layoutPreview()
        {
            //using (bitmap)
            using (var graphics = Graphics.FromImage(bitmap))
            using (var font = new Font("Arial", 20, FontStyle.Regular))
            {
                // Do what you want using the Graphics object here.
                int firstRow = Convert.ToInt32(textBoxFirstRow.Text);
                int spacing = Convert.ToInt32(textBoxRowSpacing.Text);
                int initials = Convert.ToInt32(textBoxIntial.Text);
                int number = Convert.ToInt32(textBoxRoadNumber.Text);
                int kind = Convert.ToInt32(textBoxKind.Text);
                int contents = Convert.ToInt32(textBoxContents.Text);
                int origin = Convert.ToInt32(textBoxOrigin.Text);
                int destination = Convert.ToInt32(textBoxDestination.Text);
                int tons = Convert.ToInt32(textBoxTons.Text);
                int remarks = Convert.ToInt32(textBoxRemarks.Text);
                int nrows = Convert.ToInt32(textBoxRows.Text);
                int bnrows = Convert.ToInt32(textBoxBackRowNum.Text);
                int backFirstRow = Convert.ToInt32(textBoxBackRow.Text);
                Point trainnumber = new Point(Convert.ToInt32(textBoxTrainNumber.Text.Split(',')[0]), Convert.ToInt32(textBoxTrainNumber.Text.Split(',')[1]));
                Point engineNum = new Point(Convert.ToInt32(textBoxEngineNum.Text.Split(',')[0]), Convert.ToInt32(textBoxEngineNum.Text.Split(',')[1]));
                Point station = new Point(Convert.ToInt32(textBoxStation.Text.Split(',')[0]), Convert.ToInt32(textBoxStation.Text.Split(',')[1]));
                Point year = new Point(Convert.ToInt32(textBoxYear.Text.Split(',')[0]), Convert.ToInt32(textBoxYear.Text.Split(',')[1]));
                Point time = new Point(Convert.ToInt32(textBoxTime.Text.Split(',')[0]), Convert.ToInt32(textBoxTime.Text.Split(',')[1]));
                Point date = new Point(Convert.ToInt32(textBoxDate.Text.Split(',')[0]), Convert.ToInt32(textBoxDate.Text.Split(',')[1]));

                for (int i = 0; i < nrows; i++)
                {
                    int row = firstRow + (spacing * i);

                    if (initials > 0)
                    {
                        graphics.DrawString("ATSF", font, Brushes.Blue, initials, row);
                    }

                    if (number > 0)
                    {
                        graphics.DrawString("588684", font, Brushes.Blue, number, row);
                    }

                    if (kind > 0)
                    {
                        graphics.DrawString("BTO", font, Brushes.Blue, kind, row);
                    }

                    if (contents > 0)
                    {
                        graphics.DrawString("Oranges", font, Brushes.Blue, contents, row);
                    }

                    if (origin > 0)
                    {
                        graphics.DrawString("TAFT", font, Brushes.Blue, origin, row);
                    }

                    if (destination > 0)
                    {
                        graphics.DrawString("TAFT", font, Brushes.Blue, destination, row);
                    }

                    if (tons > 0)
                    {
                        graphics.DrawString("999", font, Brushes.Blue, tons, row);
                    }

                    if (remarks > 0)
                    {
                        graphics.DrawString("Bad Order", font, Brushes.Blue, remarks, row);
                    }
                }

                graphics.DrawString("8786", font, Brushes.Blue, trainnumber.Y, trainnumber.X);
                graphics.DrawString("8786", font, Brushes.Blue, engineNum.Y, engineNum.X);
                graphics.DrawString("BAK", font, Brushes.Blue, station.Y, station.X);
                graphics.DrawString("53", font, Brushes.Blue, year.Y, year.X);
                graphics.DrawString(DateTime.Now.ToString("H:mm"), font, Brushes.Blue, time.Y, time.X);
                graphics.DrawString(DateTime.Now.ToString("MMM d,"), font, Brushes.Blue, date.Y, date.X);

                // Important part!
                bitmap.Save("temp.jpg");
            }

            pictureBox1.ImageLocation = "temp.jpg";
        }

        private void loadLayout()
        {
            try
            {
                layout = client.getSwitchListTemplate(Convert.ToInt32(comboBoxTemplates.SelectedValue));
                bitmap = BytesToBitmap(layout.image);
                textBoxName.Text = layout.name;
                textBoxFirstRow.Text = layout.firstRowStart.ToString();
                textBoxRowSpacing.Text = layout.rowSpacing.ToString();
                textBoxIntial.Text = layout.initialColumn.ToString();
                textBoxRoadNumber.Text = layout.numberColumn.ToString();
                textBoxKind.Text = layout.kindColumn.ToString();
                textBoxContents.Text = layout.contentsColumn.ToString();
                textBoxOrigin.Text = layout.originColumn.ToString();
                textBoxDestination.Text = layout.destinationColumn.ToString();
                textBoxTons.Text = layout.tonsColumn.ToString();
                textBoxRemarks.Text = layout.remarksColumn.ToString();
                textBoxRows.Text = layout.maxRows.ToString();
                textBoxBackRowNum.Text = layout.maxRowsFront.ToString();
                textBoxBackRow.Text = layout.backRowStart.ToString();
                textBoxTrainNumber.Text = layout.trainNoLocation.ToString();
                textBoxEngineNum.Text = layout.engineNoLocation.ToString();
                textBoxStation.Text = layout.stationLocation.ToString();
                textBoxYear.Text = layout.yearLocation.ToString();
                textBoxTime.Text = layout.timeLocation.ToString();
                textBoxDate.Text = layout.dateLocation.ToString();

                layoutPreview();
            }
            catch(InvalidCastException)
            {

            }
        }

        public static Bitmap BytesToBitmap(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Bitmap img = (Bitmap)Image.FromStream(ms);
                return img;
            }
        }

        public static byte[] BitmapToByte(Bitmap bitmap)
        {
            byte[] result = null;

            if (bitmap != null)
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, bitmap.RawFormat);
                result = stream.ToArray();
            }

            return result;
        }

        private void openSwitchListImage(string filePath)
        {           
            // Create from a stream so we don't keep a lock on the file.
            using (var stream = File.OpenRead(filePath))
            {
                bitmap = (Bitmap)Bitmap.FromStream(stream);
            }

            layoutPreview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.addSwitchListTemplate(textBoxName.Text, BitmapToByte(bitmap), Convert.ToInt32(textBoxFirstRow.Text), Convert.ToInt32(textBoxRowSpacing.Text), Convert.ToInt32(textBoxIntial.Text), Convert.ToInt32(textBoxRoadNumber.Text), Convert.ToInt32(textBoxKind.Text), Convert.ToInt32(textBoxOrigin.Text), Convert.ToInt32(textBoxDestination.Text), Convert.ToInt32(textBoxTons.Text), Convert.ToInt32(textBoxRemarks.Text), textBoxTrainNumber.Text, textBoxEngineNum.Text, textBoxStation.Text, textBoxTime.Text, textBoxYear.Text, textBoxDate.Text, Convert.ToInt32(textBoxRows.Text), Convert.ToInt32(textBoxBackRow.Text), Convert.ToInt32(textBoxBackRowNum.Text), Convert.ToInt32(textBoxContents.Text));
        }

        private void SetupSwitchList_Load(object sender, EventArgs e)
        {
            List<CoreWebService.SwitchListsLayout> layouts = client.listAllSwitchListTemplates().ToList<CoreWebService.SwitchListsLayout>();
            comboBoxTemplates.DataSource = layouts;
            comboBoxTemplates.DisplayMember = "name";
            comboBoxTemplates.ValueMember = "ID";
        }

        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLayout();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            client.updateSwitchListTemplate(Convert.ToInt32(comboBoxTemplates.SelectedValue), textBoxName.Text, BitmapToByte(bitmap), Convert.ToInt32(textBoxFirstRow.Text), Convert.ToInt32(textBoxRowSpacing.Text), Convert.ToInt32(textBoxIntial.Text), Convert.ToInt32(textBoxRoadNumber.Text), Convert.ToInt32(textBoxKind.Text), Convert.ToInt32(textBoxOrigin.Text), Convert.ToInt32(textBoxDestination.Text), Convert.ToInt32(textBoxTons.Text), Convert.ToInt32(textBoxRemarks.Text), textBoxTrainNumber.Text, textBoxEngineNum.Text, textBoxStation.Text, textBoxTime.Text, textBoxYear.Text, textBoxDate.Text, Convert.ToInt32(textBoxRows.Text), Convert.ToInt32(textBoxBackRow.Text), Convert.ToInt32(textBoxBackRowNum.Text), Convert.ToInt32(textBoxContents.Text));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            client.deleteSwitchListTemplate(Convert.ToInt32(comboBoxTemplates.SelectedValue));
        }
    }
}
