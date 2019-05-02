using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;
using System.IO;

namespace FFD_GUI
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Apply_sensor1_Click(object sender, EventArgs e)
        {
            
            
        }
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "Saxion Lab", text, ToolTipIcon.Error);
        }

        private void Sensor1_yaxis_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
