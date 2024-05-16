namespace com_port
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.slcFile = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkNone = new System.Windows.Forms.CheckBox();
            this.checkOdd = new System.Windows.Forms.CheckBox();
            this.checkEven = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBit = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(570, 15);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(74, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Bağlan";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(304, 22);
            this.cboPort.Margin = new System.Windows.Forms.Padding(2);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(156, 21);
            this.cboPort.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(570, 56);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Durdur";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.SystemColors.Info;
            this.txtReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceive.Location = new System.Drawing.Point(16, 109);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(628, 129);
            this.txtReceive.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(16, 283);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(628, 129);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(570, 422);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 29);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(290, 491);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 29);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(570, 492);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(76, 29);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Yükle";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 498);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hex Dosyası:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alınan:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gönderilen:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Com Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(304, 47);
            this.cboBaudrate.Margin = new System.Windows.Forms.Padding(2);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(156, 21);
            this.cboBaudrate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Baudrate:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // slcFile
            // 
            this.slcFile.Location = new System.Drawing.Point(87, 497);
            this.slcFile.Margin = new System.Windows.Forms.Padding(2);
            this.slcFile.Name = "slcFile";
            this.slcFile.Size = new System.Drawing.Size(180, 20);
            this.slcFile.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 422);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkNone
            // 
            this.checkNone.AutoSize = true;
            this.checkNone.Checked = true;
            this.checkNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNone.Location = new System.Drawing.Point(62, 21);
            this.checkNone.Margin = new System.Windows.Forms.Padding(2);
            this.checkNone.Name = "checkNone";
            this.checkNone.Size = new System.Drawing.Size(52, 17);
            this.checkNone.TabIndex = 6;
            this.checkNone.Text = "None";
            this.checkNone.UseVisualStyleBackColor = true;
            this.checkNone.CheckedChanged += new System.EventHandler(this.checkNone_CheckedChanged);
            // 
            // checkOdd
            // 
            this.checkOdd.AutoSize = true;
            this.checkOdd.Location = new System.Drawing.Point(122, 21);
            this.checkOdd.Margin = new System.Windows.Forms.Padding(2);
            this.checkOdd.Name = "checkOdd";
            this.checkOdd.Size = new System.Drawing.Size(46, 17);
            this.checkOdd.TabIndex = 6;
            this.checkOdd.Text = "Odd";
            this.checkOdd.UseVisualStyleBackColor = true;
            this.checkOdd.CheckedChanged += new System.EventHandler(this.checkOdd_CheckedChanged);
            // 
            // checkEven
            // 
            this.checkEven.AutoSize = true;
            this.checkEven.Location = new System.Drawing.Point(176, 22);
            this.checkEven.Margin = new System.Windows.Forms.Padding(2);
            this.checkEven.Name = "checkEven";
            this.checkEven.Size = new System.Drawing.Size(51, 17);
            this.checkEven.TabIndex = 6;
            this.checkEven.Text = "Even";
            this.checkEven.UseVisualStyleBackColor = true;
            this.checkEven.CheckedChanged += new System.EventHandler(this.checkEven_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Parity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Boyut:";
            // 
            // cboBit
            // 
            this.cboBit.Location = new System.Drawing.Point(62, 46);
            this.cboBit.Margin = new System.Windows.Forms.Padding(2);
            this.cboBit.Name = "cboBit";
            this.cboBit.Size = new System.Drawing.Size(92, 21);
            this.cboBit.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(382, 499);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(172, 12);
            this.progressBar1.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(480, 31);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 29);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bootloader Yükle:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1112, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(914, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Plot";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(680, 56);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(506, 465);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 550);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cboBit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkEven);
            this.Controls.Add(this.checkOdd);
            this.Controls.Add(this.checkNone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.slcFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.cboBaudrate);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Com Port App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox slcFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkNone;
        private System.Windows.Forms.CheckBox checkOdd;
        private System.Windows.Forms.CheckBox checkEven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

