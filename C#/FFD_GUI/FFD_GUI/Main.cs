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
        private Thread cpuThread;
        private double[] cpuArray = new double[60];
        #region global variables
        public string com_port { get; set; }
        public string baud_rate { get; set; }
        private string readBuffer = string.Empty;  // buffer to store characters
        private Options options;
        private Connection connection;
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

        #region connect to serial port open port set parameters and run timer
        public void connect_Click(object sender, EventArgs e)

        {
            if (!serialPort1.IsOpen)
            {
                try
                {          
                        serialPort1.PortName = com_port;
                        serialPort1.BaudRate = Convert.ToInt32(baud_rate);
                        serialPort1.Open();
                        serialPort1.ReceivedBytesThreshold = 20; //threshold 20 bytes received  event trigger
                        serialPort1.NewLine = "\r";               // last char to be recognised
                        serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                }
                catch (UnauthorizedAccessException)
                {
                   //TODO: Later give notice user
                }
            }
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
            connection = new Connection();
            connection.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            options = new Options();
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
    }
}
