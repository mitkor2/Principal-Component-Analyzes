using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Threading;

namespace FFD_GUI
{
    public partial class Connection : Form
    {
        //input data receive from serialport
        string sttheta;
        string stpsi;
        string stphi;
        string staddtheta;
        string staddphi;
        private Main mainForm = null;
        public Connection(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Main;
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPorts.Text != "")
                {
                    if (cbBaud.Text != "")
                    {
                        serialPort1.PortName = cbPorts.Text;
                        label1.Text = cbPorts.Text;
                        label3.Text = cbBaud.Text;
                        serialPort1.BaudRate = Convert.ToInt32(cbBaud.Text);
                        serialPort1.Parity = Parity.None;
                        serialPort1.StopBits = StopBits.One;
                        serialPort1.DataBits = 8;
                        serialPort1.Handshake = Handshake.None;
                        serialPort1.RtsEnable = true;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                        if (serialPort1.IsOpen) return;
                        serialPort1.Open();
                        btnConn.Enabled = false;
                        btnDisConn.Enabled = true;
                        //
                        

                        cbBaud.Enabled = false;
                        cbPorts.Enabled = false;

                    }
                    else
                        return;
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }
        private void BtnDisConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false) return;
                serialPort1.Close();
                btnConn.Enabled = true;
                btnDisConn.Enabled = false;
                //
                cbBaud.Enabled = true;
                cbPorts.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //split data receive from serialport
                string[] arrList = serialPort1.ReadLine().Split(',');
                this.mainForm.port_sensor1 = arrList[0];
                this.mainForm.port_sensor2 = arrList[1];
                this.mainForm.port_sensor3 = arrList[2];
                this.mainForm.port_sensor4 = arrList[3];
                this.mainForm.port_sensor5 = arrList[4];
                this.mainForm.port_sensor6 = arrList[5];
                this.mainForm.port_sensor7 = arrList[6];
                this.mainForm.port_sensor8 = arrList[7];
                this.mainForm.port_sensor9 = arrList[8];
                this.mainForm.port_sensor10 = arrList[9];
                this.mainForm.port_sensor11 = arrList[10];
                this.mainForm.port_sensor12 = arrList[11];
                this.mainForm.port_sensor13 = arrList[12];
                stpsi = arrList[0];// Psi value.
                sttheta = arrList[1];// Theta value.
                stphi = arrList[2];// Phi value.
                staddtheta = arrList[3];// Theta setpoint value.
                staddphi = arrList[4];// Phi setpoint value.
            }
            catch
            {
                return;
            }
        }
        int intlen = 0;
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (btnConn.Enabled == false)
            {
                Draw(stpsi, sttheta, stphi, staddtheta, staddphi);
                //display value on graph
                // text color and value
                lblpsi.ForeColor = Color.Blue;
                lblpsi.Text = stpsi;

                lbltheta.ForeColor = Color.Blue;
                lbltheta.Text = sttheta;

                lblphi.ForeColor = Color.Blue;
                lblphi.Text = stphi;

                lblstheta.ForeColor = Color.Red;
                lblstheta.Text = staddtheta;

                lblsphi.ForeColor = Color.Red;
                lblsphi.Text = staddphi;
            }
            //auto detect COM port//
            string[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                cbPorts.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    cbPorts.Items.Add(ports[j]);
                }
            }
        }
        //
        int TickStart1;
        int TickStart2;
        int TickStart3;

        private void Connection_Load(object sender, EventArgs e)
        {
            cbBaud.Enabled = true;
            cbPorts.Enabled = true;
            //Disable button control

            //Load value//
            cbBaud.Items.Add(9600);
            cbBaud.Items.Add(14400);
            cbBaud.Items.Add(19200);
            cbBaud.Items.Add(38400);
            cbBaud.Items.Add(57600);
            cbBaud.Items.Add(74880);
            cbBaud.Items.Add(115200);
            cbBaud.Items.Add(230400);
            cbBaud.Items.Add(256000);
            cbBaud.Items.Add(460800);
            cbBaud.Items.Add(921600);
            //
            btnDisConn.Enabled = false;

            //Show contents of graph
            //Name graph
            //Value x,y axis..
            GraphPane myPane1 = zedGraphControl1.GraphPane;
            myPane1.Title.Text = "Psi Graph";
            myPane1.XAxis.Title.Text = "Time, Seconds";
            myPane1.YAxis.Title.Text = "Angle, Deg";

            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem Curve1 = myPane1.AddCurve("Psi Value", list1, Color.Blue, SymbolType.None);

            myPane1.XAxis.Scale.Min = 0;
            myPane1.XAxis.Scale.Max = 10;
            myPane1.YAxis.Scale.Min = -10;
            myPane1.YAxis.Scale.Max = 10;

            zedGraphControl1.AxisChange();
            TickStart1 = Environment.TickCount;

            /*Display the graph 2 of contents*/
            //Psidot graph//
            GraphPane myPane2 = zedGraphControl2.GraphPane;
            myPane2.Title.Text = "Theta Graph";
            myPane2.XAxis.Title.Text = "Time, Seconds";
            myPane2.YAxis.Title.Text = "Angle, Deg";

            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem Curve2 = myPane2.AddCurve("Theta Value", list2, Color.Blue, SymbolType.None);
            //
            RollingPointPairList list2_ = new RollingPointPairList(60000);
            LineItem Curve2_ = myPane2.AddCurve("Setpoint", list2_, Color.Red, SymbolType.None);

            myPane2.XAxis.Scale.Min = 0;
            myPane2.XAxis.Scale.Max = 10;
            myPane2.YAxis.Scale.Min = -540;
            myPane2.YAxis.Scale.Max = 540;

            zedGraphControl2.AxisChange();
            TickStart2 = Environment.TickCount;

            /*Display the graph 3 of contents*/
            //Theta graph//
            GraphPane myPane3 = zedGraphControl3.GraphPane;
            myPane3.Title.Text = "Phi Graph";//Ten do thi
            myPane3.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane3.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y

            RollingPointPairList list3 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve3 = myPane3.AddCurve("Phi Vallue", list3, Color.Blue, SymbolType.None);//Chon mau cho net ve

            RollingPointPairList list3_ = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve3_ = myPane3.AddCurve("Setpoint", list3_, Color.Red, SymbolType.None);//Chon mau cho net ve

            myPane3.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane3.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane3.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane3.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl3.AxisChange();//Tu do Scroll do thi
            TickStart3 = Environment.TickCount;
        }

        //Draw line in the zedgraph using string data    //
        //receive from serialport convert to double value//
        private void Draw(string inpsi, string intheta, string inphi, string inaddtheta, string inaddphi)
        {
            double _psi;
            double _theta;
            double _phi;
            double _addtheta;
            double _addphi;

            double.TryParse(inpsi, out _psi);//Conver tring to double//
            double.TryParse(intheta, out _theta);//Conver tring to double//
            double.TryParse(inphi, out _phi);//Conver tring to double//
            double.TryParse(inaddtheta, out _addtheta);
            double.TryParse(inaddphi, out _addphi);

            //Error color text
            lblphierror.ForeColor = Color.Blue;
            lblthetaerror.ForeColor = Color.Blue;
            //Error value update...
            lblthetaerror.Text = Math.Round((Math.Abs(_theta) - Math.Abs(_addtheta)), 2).ToString();
            lblphierror.Text = Math.Round((Math.Abs(_phi) - Math.Abs(_addphi)), 2).ToString();

            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl2.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl3.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl2.GraphPane.CurveList[0] as LineItem;
            LineItem curve3 = zedGraphControl3.GraphPane.CurveList[0] as LineItem;

            LineItem curve2_ = zedGraphControl2.GraphPane.CurveList[1] as LineItem;// SetPoint Curve Theta
            LineItem curve3_ = zedGraphControl3.GraphPane.CurveList[1] as LineItem;// SetPoint Curve Phi

            if (curve1 == null)
                return;
            if (curve2 == null)
                return;
            if (curve3 == null)
                return;
            if (curve2_ == null)
                return;
            if (curve3_ == null)
                return;

            //
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            //
            IPointListEdit list2_ = curve2_.Points as IPointListEdit;
            IPointListEdit list3_ = curve3_.Points as IPointListEdit;

            //
            if (list1 == null)
                return;
            if (list2 == null)
                return;
            if (list3 == null)
                return;
            //
            if (list2_ == null)
                return;
            if (list3_ == null)
                return;

            //
            double time1 = (Environment.TickCount - TickStart1) / 1000.0;
            double time2 = (Environment.TickCount - TickStart2) / 1000.0;
            double time3 = (Environment.TickCount - TickStart3) / 1000.0;

            //
            list1.Add(time1, _psi);
            list2.Add(time2, _theta);
            list3.Add(time3, _phi);
            //
            list2_.Add(time2, (_addtheta));
            list3_.Add(time3, (_addphi));

            //
            Scale xScale1 = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale xScale2 = zedGraphControl2.GraphPane.XAxis.Scale;
            Scale xScale3 = zedGraphControl3.GraphPane.XAxis.Scale;

            //
            Scale yScale1 = zedGraphControl1.GraphPane.YAxis.Scale;
            Scale yScale2 = zedGraphControl2.GraphPane.YAxis.Scale;
            Scale yScale3 = zedGraphControl3.GraphPane.YAxis.Scale;

            //
            if (time1 > xScale1.Max - xScale1.MajorStep)
            {
                xScale1.Max = time1 + xScale1.MajorStep;
                xScale1.Min = xScale1.Max - 10;//Auto scale x axis in limit time
            }
            if (time2 > xScale2.Max - xScale2.MajorStep)
            {
                xScale2.Max = time2 + xScale2.MajorStep;
                xScale2.Min = xScale2.Max - 30;
            }
            if (time3 > xScale3.Max - xScale3.MajorStep)
            {
                xScale3.Max = time3 + xScale3.MajorStep;
                xScale3.Min = xScale3.Max - 30;
            }
            //
            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
            zedGraphControl3.AxisChange();
            //
            zedGraphControl1.Invalidate();
            zedGraphControl2.Invalidate();
            zedGraphControl3.Invalidate();
        }

        private void CbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
 

        private void Lbltheta_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ZedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
