using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Appliances;
using Appliances.Appliance;

namespace Devices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void loadXmlButton_Click(object sender, EventArgs e)
        {
            var applianse = new ElecricDevicesInHouse();
            FileStream myStream = null;
            var openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    applianse.LoadFromXml(myStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            var bindingList = new BindingList<ElectricDevice>(applianse.ElectricDevices);
            var source = new BindingSource(bindingList, null);
            devicesDataGridView.DataSource = source;
        }
    }
}