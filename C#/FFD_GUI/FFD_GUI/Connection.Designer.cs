namespace FFD_GUI
{
    partial class Connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.lblphierror = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthetaerror = new System.Windows.Forms.Label();
            this.lblsphi = new System.Windows.Forms.Label();
            this.lblphi = new System.Windows.Forms.Label();
            this.lblpsi = new System.Windows.Forms.Label();
            this.lblstheta = new System.Windows.Forms.Label();
            this.lbltheta = new System.Windows.Forms.Label();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.lblBaud = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1399, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phi Error";
            // 
            // lblphierror
            // 
            this.lblphierror.AutoSize = true;
            this.lblphierror.BackColor = System.Drawing.Color.White;
            this.lblphierror.Location = new System.Drawing.Point(1470, 431);
            this.lblphierror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphierror.Name = "lblphierror";
            this.lblphierror.Size = new System.Drawing.Size(39, 17);
            this.lblphierror.TabIndex = 10;
            this.lblphierror.Text = "error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(614, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Theta Error";
            // 
            // lblthetaerror
            // 
            this.lblthetaerror.AutoSize = true;
            this.lblthetaerror.BackColor = System.Drawing.Color.White;
            this.lblthetaerror.Location = new System.Drawing.Point(702, 431);
            this.lblthetaerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthetaerror.Name = "lblthetaerror";
            this.lblthetaerror.Size = new System.Drawing.Size(39, 17);
            this.lblthetaerror.TabIndex = 12;
            this.lblthetaerror.Text = "error";
            // 
            // lblsphi
            // 
            this.lblsphi.AutoSize = true;
            this.lblsphi.BackColor = System.Drawing.Color.White;
            this.lblsphi.Location = new System.Drawing.Point(1005, 458);
            this.lblsphi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsphi.Name = "lblsphi";
            this.lblsphi.Size = new System.Drawing.Size(34, 17);
            this.lblsphi.TabIndex = 20;
            this.lblsphi.Text = "sphi";
            // 
            // lblphi
            // 
            this.lblphi.AutoSize = true;
            this.lblphi.BackColor = System.Drawing.Color.White;
            this.lblphi.Location = new System.Drawing.Point(901, 458);
            this.lblphi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphi.Name = "lblphi";
            this.lblphi.Size = new System.Drawing.Size(27, 17);
            this.lblphi.TabIndex = 19;
            this.lblphi.Text = "phi";
            // 
            // lblpsi
            // 
            this.lblpsi.AutoSize = true;
            this.lblpsi.BackColor = System.Drawing.Color.White;
            this.lblpsi.Location = new System.Drawing.Point(901, 107);
            this.lblpsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpsi.Name = "lblpsi";
            this.lblpsi.Size = new System.Drawing.Size(26, 17);
            this.lblpsi.TabIndex = 18;
            this.lblpsi.Text = "psi";
            // 
            // lblstheta
            // 
            this.lblstheta.AutoSize = true;
            this.lblstheta.BackColor = System.Drawing.Color.White;
            this.lblstheta.Location = new System.Drawing.Point(241, 458);
            this.lblstheta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstheta.Name = "lblstheta";
            this.lblstheta.Size = new System.Drawing.Size(47, 17);
            this.lblstheta.TabIndex = 21;
            this.lblstheta.Text = "stheta";
            // 
            // lbltheta
            // 
            this.lbltheta.AutoSize = true;
            this.lbltheta.BackColor = System.Drawing.Color.White;
            this.lbltheta.Location = new System.Drawing.Point(134, 458);
            this.lbltheta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltheta.Name = "lbltheta";
            this.lbltheta.Size = new System.Drawing.Size(40, 17);
            this.lbltheta.TabIndex = 22;
            this.lbltheta.Text = "theta";
            this.lbltheta.Click += new System.EventHandler(this.Lbltheta_Click);
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl3.Location = new System.Drawing.Point(783, 395);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(760, 345);
            this.zedGraphControl3.TabIndex = 16;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(783, 42);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(760, 345);
            this.zedGraphControl1.TabIndex = 14;
            this.zedGraphControl1.Load += new System.EventHandler(this.ZedGraphControl1_Load);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(64, 33);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(104, 28);
            this.cbPorts.TabIndex = 5;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.CbPorts_SelectedIndexChanged);
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(64, 70);
            this.cbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(104, 28);
            this.cbBaud.TabIndex = 5;
            // 
            // btnDisConn
            // 
            this.btnDisConn.Location = new System.Drawing.Point(202, 74);
            this.btnDisConn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(137, 28);
            this.btnDisConn.TabIndex = 0;
            this.btnDisConn.Text = "Disconnect";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.BtnDisConn_Click);
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(8, 78);
            this.lblBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(48, 20);
            this.lblBaud.TabIndex = 1;
            this.lblBaud.Text = "Baud";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(202, 33);
            this.btnConn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(137, 28);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(8, 37);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(40, 20);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.IsScrollY2 = true;
            this.zedGraphControl2.IsShowPointValues = true;
            this.zedGraphControl2.Location = new System.Drawing.Point(14, 395);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(760, 345);
            this.zedGraphControl2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPorts);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.btnDisConn);
            this.groupBox1.Controls.Add(this.lblBaud);
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(439, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Baud";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 773);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblphierror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblthetaerror);
            this.Controls.Add(this.lblsphi);
            this.Controls.Add(this.lblphi);
            this.Controls.Add(this.lblpsi);
            this.Controls.Add(this.lblstheta);
            this.Controls.Add(this.lbltheta);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblphierror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblthetaerror;
        private System.Windows.Forms.Label lblsphi;
        private System.Windows.Forms.Label lblphi;
        private System.Windows.Forms.Label lblpsi;
        private System.Windows.Forms.Label lblstheta;
        private System.Windows.Forms.Label lbltheta;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}