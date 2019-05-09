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
    public partial class Connection : Form
    {
        public string data { get; set; }
        public int[] data_sensors{ get; private set; }

        int graph_scaler = 500;
        //int send_repeat_counter = 0;
        //bool send_data_flag = false;
        bool plotter_flag = false;
        System.IO.StreamWriter out_file;
        System.IO.StreamReader in_file;

        public Connection()
        {
            InitializeComponent();
            configrations();
        }
        public void configrations()
        {
            portConfig.Items.AddRange(SerialPort.GetPortNames());
            baudrateConfig.DataSource = new[] { "115200", "19200", "230400", "57600", "38400", "9600", "4800" };
            parityConfig.DataSource = new[] { "None", "Odd", "Even", "Mark", "Space" };
            databitsConfig.DataSource = new[] { "5", "6", "7", "8" };
            stopbitsConfig.DataSource = new[] { "1", "2", "1.5" };
            flowcontrolConfig.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };
            //portConfig.SelectedIndex = 0;
            baudrateConfig.SelectedIndex = 5;
            parityConfig.SelectedIndex = 0;
            databitsConfig.SelectedIndex = 3;
            stopbitsConfig.SelectedIndex = 0;
            flowcontrolConfig.SelectedIndex = 0;
            openFileDialog1.Filter = "Text|*.txt";

            mySerial.DataReceived += rx_data_event;
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_rxtextarea_event);
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selecting);

            for (int i = 0; i < 5 && i < 5; i++)
                graph.Series[i].Points.Add(0);

        }
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "Saxion Lab", text, ToolTipIcon.Error);
        }
        private void rx_data_event(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (mySerial.IsOpen)
            {
                try
                {
                    int dataLength = mySerial.BytesToRead;
                    byte[] dataRecevied = new byte[dataLength];
                    int nbytes = mySerial.Read(dataRecevied, 0, dataLength);
                    if (nbytes == 0) return;
                    if (datalogger_checkbox.Checked)
                    {
                        try
                        { out_file.Write(data.Replace("\\n", Environment.NewLine)); }
                        catch { alert("Can't write to " + datalogger_checkbox.Text + " file it might be not exist or it is opennd in another program"); return; }
                    }


                    this.BeginInvoke((Action)(() =>
                    {
                        data = System.Text.Encoding.Default.GetString(dataRecevied);

                        if (!plotter_flag && !backgroundWorker1.IsBusy)
                        {
                            if (display_hex_radiobutton.Checked)
                                data = BitConverter.ToString(dataRecevied);

                            backgroundWorker1.RunWorkerAsync();
                        }

                        else if (plotter_flag)
                        {
                            double number;
                            string[] variables = data.Split('\n')[0].Split(',');
                            for (int i = 0; i < variables.Length && i < 5; i++)
                            {
                                if (double.TryParse(variables[i], out number))
                                {
                                    if (graph.Series[i].Points.Count > graph_scaler)
                                        graph.Series[i].Points.RemoveAt(0);
                                    graph.Series[i].Points.Add(number);
                                }
                            }
                            graph.ResetAutoValues();
                        }
                    }));
                }
                catch { alert("Can't read form  " + mySerial.PortName + " port it might be opennd in another program"); }
            }
        }
        void tabControl1_Selecting(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                plotter_flag = true;
            else
                plotter_flag = false;
        }

        /* Append text to rx_textarea*/
        private void update_rxtextarea_event(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (rx_textarea.Lines.Count() > 5000)
                    rx_textarea.ResetText();
                rx_textarea.AppendText("[RX   NEW DATA]> " + data);
            }));
        }
        private bool Serial_port_config()
        {
            try { mySerial.PortName = portConfig.Text; }
            catch { alert("There are no available ports"); return false; }
            mySerial.BaudRate = (Int32.Parse(baudrateConfig.Text));
            mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopbitsConfig.SelectedIndex + 1).ToString(), true);
            mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), parityConfig.SelectedIndex.ToString(), true);
            mySerial.DataBits = (Int32.Parse(databitsConfig.Text));
            mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowcontrolConfig.SelectedIndex.ToString(), true);

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void set_Click(object sender, EventArgs e)
        {
           /* try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
                //while(true)
                //{
                    Console.WriteLine(serialPort1.ReadLine());
                //}             
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Main main = new Main();
            // main.com_port = comboBox1.Text;
            // main.baud_rate = comboBox2.Text;
            //main.Dispose();*/

        }
        private void Button1_Click(object sender, EventArgs e)
        {
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Serial_options_group_Enter(object sender, EventArgs e)
        {

        }

        private void Datalogger_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (datalogger_checkbox.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    datalogger_checkbox.Text = openFileDialog1.FileName;
                    datalogger_append_radiobutton.Enabled = true;
                    datalogger_overwrite_radiobutton.Enabled = true;
                    datalogger_append_radiobutton.Enabled = true;
                    datalogger_overwrite_radiobutton.Enabled = true;
                }
                else
                {
                    datalogger_checkbox.Checked = false;
                    datalogger_append_radiobutton.Enabled = false;
                    datalogger_overwrite_radiobutton.Enabled = false;
                    datalogger_append_radiobutton.Enabled = false;
                    datalogger_overwrite_radiobutton.Enabled = false;
                }
            }
            else
            {
                datalogger_append_radiobutton.Enabled = false;
                datalogger_overwrite_radiobutton.Enabled = false;
                datalogger_checkbox.Text = "Enable Data logger";
            }
        }
        private void UserControl_state(bool value)
        {
            datalogger_options_panel.Enabled = !value;
            write_options_group.Enabled = value;

            if (value)
            {
                connect.Text = "Disconnected";
                toolStripStatusLabel1.Text = "Connected port: " + mySerial.PortName + " @ " + mySerial.BaudRate + " bps";
            }
            else
            {
                connect.Text = "Connected";
                toolStripStatusLabel1.Text = "No Connection";
            }
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            /*Connect*/
            if (!mySerial.IsOpen)
            {
                if (Serial_port_config())
                {
                    try
                    {
                        mySerial.Open();
                    }
                    catch
                    {
                        alert("Can't open " + mySerial.PortName + " port, it might be used in another program");
                        return;
                    }

                    if (datalogger_checkbox.Checked)
                    {
                        try
                        {
                            out_file = new System.IO.StreamWriter(datalogger_checkbox.Text, datalogger_append_radiobutton.Checked);
                        }
                        catch
                        {
                            alert("Can't open " + datalogger_checkbox.Text + " file, it might be used in another program");
                            return;
                        }
                    }

                    UserControl_state(true);
                }
            }

            /*Disconnect*/
            else if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.Close();
                    mySerial.DiscardInBuffer();
                    mySerial.DiscardOutBuffer();
                }
                catch {/*ignore*/}

                if (datalogger_checkbox.Checked)
                    try { out_file.Dispose(); }
                    catch {/*ignore*/ }

                try { in_file.Dispose(); }
                catch {/*ignore*/ }

                UserControl_state(false);
            }
        }

        private void Rx_textarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alert_messege_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
