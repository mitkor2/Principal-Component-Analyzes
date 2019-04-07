using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFD_GUI
{
    public partial class Main : Form
    {
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
    }
}
