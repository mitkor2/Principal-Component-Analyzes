using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace FFD_GUI
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }


        #region getting available ports
        private void getAvailablePorts(object sender, EventArgs e)
        {
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox1.Items.AddRange(ports);
            }

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void set_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.com_port = comboBox1.Text;
            main.baud_rate = comboBox2.Text;
            main.Dispose();
        }
    }
}
