using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace FFD_GUI
{
    public partial class Main : Form
    {
        class Settings
        {
            public string[] returndata = new string[65];
            public string[] Yaxis = new string[13];
            public string[] Xaxis = new string[13];
            public string[] Danger1 = new string[13];
            public string[] Danger2 = new string[13];
            public string[] Danger3 = new string[13];
            public string[] sensor_data = new string[13];
        }
        class Datacon
        {
            public string[] rdata = new string[13];
            public string[] dataport_sensor = new string[13];
        }
        Datacon d = new Datacon();
        Settings u = new Settings();
        public string port_sensor1 { get { return d.rdata[0]; } set { d.dataport_sensor[0] = value; } }
        public string port_sensor2 { get { return d.rdata[1]; } set { d.dataport_sensor[1] = value; } }
        public string port_sensor3 { get { return d.rdata[2]; } set { d.dataport_sensor[2] = value; } }
        public string port_sensor4 { get { return d.rdata[3]; } set { d.dataport_sensor[3] = value; } }
        public string port_sensor5 { get { return d.rdata[4]; } set { d.dataport_sensor[4] = value; } }
        public string port_sensor6 { get { return d.rdata[5]; } set { d.dataport_sensor[5] = value; } }
        public string port_sensor7 { get { return d.rdata[6]; } set { d.dataport_sensor[6] = value; } }
        public string port_sensor8 { get { return d.rdata[7]; } set { d.dataport_sensor[7] = value; } }
        public string port_sensor9 { get { return d.rdata[8]; } set { d.dataport_sensor[8] = value; } }
        public string port_sensor10{ get { return d.rdata[9]; } set { d.dataport_sensor[9] = value; } }
        public string port_sensor11 { get { return d.rdata[10]; } set { d.dataport_sensor[10] = value; } }
        public string port_sensor12 { get { return d.rdata[11]; } set { d.dataport_sensor[11] = value; } }
        public string port_sensor13 { get { return d.rdata[12]; } set { d.dataport_sensor[12] = value; } }
        public string value_sensor1_y{get { return u.returndata[0]; }set { u.Yaxis[0] = value; }}
        public string value_sensor2_y { get { return u.returndata[1]; } set { u.Yaxis[1] = value; } }
        public string value_sensor3_y { get { return u.returndata[2]; } set { u.Yaxis[2] = value; } }
        public string value_sensor4_y { get { return u.returndata[3]; } set { u.Yaxis[3] = value; } }
        public string value_sensor5_y { get { return u.returndata[4]; } set { u.Yaxis[4] = value; } }
        public string value_sensor6_y { get { return u.returndata[5]; } set { u.Yaxis[5] = value; } }
        public string value_sensor7_y { get { return u.returndata[6]; } set { u.Yaxis[6] = value; } }
        public string value_sensor8_y { get { return u.returndata[7]; } set { u.Yaxis[7] = value; } }
        public string value_sensor9_y { get { return u.returndata[8]; } set { u.Yaxis[8] = value; } }
        public string value_sensor10_y { get { return u.returndata[9]; } set { u.Yaxis[9] = value; } }
        public string value_sensor11_y { get { return u.returndata[10]; } set { u.Yaxis[10] = value; } }
        public string value_sensor12_y { get { return u.returndata[11]; } set { u.Yaxis[11] = value; } }
        public string value_sensor13_y { get { return u.returndata[12]; } set { u.Yaxis[12] = value; } }
        public string value_sensor1_x { get { return u.returndata[13]; } set { u.Xaxis[0] = value; } }
        public string value_sensor2_x { get { return u.returndata[14]; } set { u.Xaxis[1] = value; } }
        public string value_sensor3_x { get { return u.returndata[15]; } set { u.Xaxis[2] = value; } }
        public string value_sensor4_x { get { return u.returndata[16]; } set { u.Xaxis[3] = value; } }
        public string value_sensor5_x { get { return u.returndata[17]; } set { u.Xaxis[4] = value; } }
        public string value_sensor6_x { get { return u.returndata[18]; } set { u.Xaxis[5] = value; } }
        public string value_sensor7_x { get { return u.returndata[19]; } set { u.Xaxis[6] = value; } }
        public string value_sensor8_x { get { return u.returndata[20]; } set { u.Xaxis[7] = value; } }
        public string value_sensor9_x { get { return u.returndata[21]; } set { u.Xaxis[8] = value; } }
        public string value_sensor10_x { get { return u.returndata[22]; } set { u.Xaxis[9] = value; } }
        public string value_sensor11_x { get { return u.returndata[23]; } set { u.Xaxis[10] = value; } }
        public string value_sensor12_x { get { return u.returndata[24]; } set { u.Xaxis[11] = value; } }
        public string value_sensor13_x { get { return u.returndata[25]; } set { u.Xaxis[12] = value; } }
        public string value_sensor1_d1 { get { return u.returndata[26]; } set { u.Danger1[0] = value; } }
        public string value_sensor2_d1 { get { return u.returndata[27]; } set { u.Danger1[1] = value; } }
        public string value_sensor3_d1 { get { return u.returndata[28]; } set { u.Danger1[2] = value; } }
        public string value_sensor4_d1 { get { return u.returndata[29]; } set { u.Danger1[3] = value; } }
        public string value_sensor5_d1 { get { return u.returndata[30]; } set { u.Danger1[4] = value; } }
        public string value_sensor6_d1 { get { return u.returndata[31]; } set { u.Danger1[5] = value; } }
        public string value_sensor7_d1 { get { return u.returndata[32]; } set { u.Danger1[6] = value; } }
        public string value_sensor8_d1 { get { return u.returndata[33]; } set { u.Danger1[7] = value; } }
        public string value_sensor9_d1 { get { return u.returndata[34]; } set { u.Danger1[8] = value; } }
        public string value_sensor10_d1 { get { return u.returndata[35]; } set { u.Danger1[9] = value; } }
        public string value_sensor11_d1 { get { return u.returndata[36]; } set { u.Danger1[10] = value; } }
        public string value_sensor12_d1 { get { return u.returndata[37]; } set { u.Danger1[11] = value; } }
        public string value_sensor13_d1 { get { return u.returndata[38]; } set { u.Danger1[12] = value; } }
        public string value_sensor1_d2 { get { return u.returndata[39]; } set { u.Danger2[0] = value; } }
        public string value_sensor2_d2 { get { return u.returndata[40]; } set { u.Danger2[1] = value; } }
        public string value_sensor3_d2 { get { return u.returndata[41]; } set { u.Danger2[2] = value; } }
        public string value_sensor4_d2 { get { return u.returndata[42]; } set { u.Danger2[3] = value; } }
        public string value_sensor5_d2 { get { return u.returndata[43]; } set { u.Danger2[4] = value; } }
        public string value_sensor6_d2 { get { return u.returndata[44]; } set { u.Danger2[5] = value; } }
        public string value_sensor7_d2 { get { return u.returndata[45]; } set { u.Danger2[6] = value; } }
        public string value_sensor8_d2 { get { return u.returndata[46]; } set { u.Danger2[7] = value; } }
        public string value_sensor9_d2 { get { return u.returndata[47]; } set { u.Danger2[8] = value; } }
        public string value_sensor10_d2 { get { return u.returndata[48]; } set { u.Danger2[9] = value; } }
        public string value_sensor11_d2 { get { return u.returndata[49]; } set { u.Danger2[10] = value; } }
        public string value_sensor12_d2 { get { return u.returndata[50]; } set { u.Danger2[11] = value; } }
        public string value_sensor13_d2 { get { return u.returndata[51]; } set { u.Danger2[12] = value; } }
        public string value_sensor1_d3 { get { return u.returndata[52]; } set { u.Danger3[0] = value; } }
        public string value_sensor2_d3 { get { return u.returndata[53]; } set { u.Danger3[1] = value; } }
        public string value_sensor3_d3 { get { return u.returndata[54]; } set { u.Danger3[2] = value; } }
        public string value_sensor4_d3 { get { return u.returndata[55]; } set { u.Danger3[3] = value; } }
        public string value_sensor5_d3 { get { return u.returndata[56]; } set { u.Danger3[4] = value; } }
        public string value_sensor6_d3 { get { return u.returndata[57]; } set { u.Danger3[5] = value; } }
        public string value_sensor7_d3 { get { return u.returndata[58]; } set { u.Danger3[6] = value; } }
        public string value_sensor8_d3 { get { return u.returndata[59]; } set { u.Danger3[7] = value; } }
        public string value_sensor9_d3 { get { return u.returndata[60]; } set { u.Danger3[8] = value; } }
        public string value_sensor10_d3 { get { return u.returndata[61]; } set { u.Danger3[9] = value; } }
        public string value_sensor11_d3 { get { return u.returndata[62]; } set { u.Danger3[10] = value; } }
        public string value_sensor12_d3 { get { return u.returndata[63]; } set { u.Danger3[11] = value; } }
        public string value_sensor13_d3 { get { return u.returndata[64]; } set { u.Danger3[12] = value; } }

        private Thread cpuThread;
        private double[] cpuArray = new double[60];
        #region global variables
        public string com_port { get; set; }
        public string baud_rate { get; set; }
        private string readBuffer = string.Empty;  // buffer to store characters
        //private Options options;
        //private Connection connection;
        private About about;
        #endregion

        public Main()
        {
            InitializeComponent();
        }

        #region update the data, enable timer for next
        public void DoUpdate(object sender, System.EventArgs e)
        {
            //TODO: here you will get data fromt the USART
            //example below
            //your varaible = readBuffer; //shows value
        }
        #endregion

        #region read databuffer received
        private void SerialPort1_DataReceived(System.Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            readBuffer = serialPort1.ReadLine();          //read the received buffer into readbuffer
            Invoke(new EventHandler(DoUpdate)); // invoke new event to update the textbox

        }
        #endregion
        
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Connection connection = new Connection(this);
           // connection = new Connection();
           connection.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options(this);
           // options = new Options();
            options.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();    
            about.Show();
        }

        private void Chart12_Click(object sender, EventArgs e)
        {

        }

        private void Chart6_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Chart5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }
        private void UpdateCpuChart()
        {
            cpuChart.Series["Series1"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["Series1"].Points.AddY(cpuArray[i]);
            }
        }
        private void Chart14_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }
        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(u.Yaxis[0]);
            //  Console.WriteLine(u.Xaxis[0]);
            // Console.WriteLine(u.Danger1[0]);
            //Console.WriteLine(u.Danger2[0]);
            //Console.WriteLine(u.Danger3[0]);
            Console.WriteLine(d.dataport_sensor[0]);
            Console.WriteLine(d.dataport_sensor[1]);
            Console.WriteLine(d.dataport_sensor[2]);
            Console.WriteLine(d.dataport_sensor[3]);
            Console.WriteLine(d.dataport_sensor[4]);
            Console.WriteLine(d.dataport_sensor[5]);
            Console.WriteLine(d.dataport_sensor[6]);
            Console.WriteLine(d.dataport_sensor[7]);
            Console.WriteLine(d.dataport_sensor[8]);
            Console.WriteLine(d.dataport_sensor[9]);
            Console.WriteLine(d.dataport_sensor[10]);
            Console.WriteLine(d.dataport_sensor[11]);
            Console.WriteLine(d.dataport_sensor[12]);

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //connection = new Connection();
            //connection.Show();
            Connection connection = new Connection(this);
            connection.Show();
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CpuChart_Click(object sender, EventArgs e)
        {

        }
    }
}
