using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.LinkLabel;
namespace com_port
{
    public partial class Form1 : Form
    {
        GraphPane myPaneSicaklik = new GraphPane();
        PointPairList listPointsRoll = new PointPairList();
        PointPairList listPointsPitch = new PointPairList();
        PointPairList listPointsYaw = new PointPairList();

        LineItem myCurveSicaklik;
        double zaman = 0;
        bool graphOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrafikHazırla();
            string[] ports = SerialPort.GetPortNames();
            List<string> baudRates = new List<string>()
            {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"
            };
            List<string> bits = new List<string>()
            {
                "5",
                "6",
                "7",
                "8",
                "9",
                "10"
            };

            checkNone.Checked = true;
            checkOdd.Checked = false;
            checkEven.Checked = false;

            cboBit.Items.AddRange(bits.ToArray());
            cboBit.SelectedIndex = 3;

            cboBaudrate.Items.AddRange(baudRates.ToArray());
            cboBaudrate.SelectedIndex = 8;

            cboPort.Items.AddRange(ports);
            try{ cboPort.SelectedIndex = 0; }
            catch
            (Exception ex)
            { MessageBox.Show("Hiç com portu yok!!: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            btnClose.Enabled = false;
            
        }


        private void GrafikHazırla()
        {
            myPaneSicaklik = zedGraphControl1.GraphPane;
            myPaneSicaklik.Title.Text = "Plot";
            myPaneSicaklik.XAxis.Title.Text = "Time  t ";
            myPaneSicaklik.YAxis.Title.Text = "Value";

            myPaneSicaklik.YAxis.Scale.Min = 0;
            myPaneSicaklik.YAxis.Scale.Max = 1000;

            myCurveSicaklik = myPaneSicaklik.AddCurve(null, listPointsRoll, Color.Red, SymbolType.None);
            myCurveSicaklik = myPaneSicaklik.AddCurve(null, listPointsPitch, Color.Blue, SymbolType.None);
            myCurveSicaklik = myPaneSicaklik.AddCurve(null, listPointsYaw, Color.Green, SymbolType.None);
            myCurveSicaklik.Line.Width = 4;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cboPort.Text != "")
                {
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    btnSelect.Enabled = true;
                    if (txtMessage.ForeColor != Color.Green)
                    {
                        btnSend.Enabled = true;
                    }
                    if (slcFile.Text != "")
                    {
                        btnUpload.Enabled = true;
                    }
                    cboBaudrate.Enabled = false;
                    cboBit.Enabled = false;
                    cboPort.Enabled = false;
                    checkEven.Enabled = false;
                    checkOdd.Enabled = false;
                    checkNone.Enabled = false;
                }


                serialPort1.PortName = cboPort.Text;
                serialPort1.BaudRate = int.Parse(cboBaudrate.Text);
                serialPort1.DataBits = int.Parse(cboBit.Text);
                if (checkEven.Checked) { serialPort1.Parity = Parity.Even;
                    //txtMessage.Text = "even";
                } else if(checkOdd.Checked){ serialPort1.Parity = Parity.Odd;
                    //txtMessage.Text = "odd";
                } else { serialPort1.Parity = Parity.None;
                    //txtMessage.Text = "none";
                }
                serialPort1.Open();
            }
            catch
            (Exception ex)
            { MessageBox.Show("Bağlantıda bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            serialPort1.DataReceived += SerialPort_DataReceived;
            //txtReceive.AppendText(serialPort1.ReadExisting() + Environment.NewLine);//"sdjfkgos" + Environment.NewLine);

        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        if (serialPort1.IsOpen)
            {
                SerialPort serialPort = (SerialPort)sender;
                string receivedData = serialPort.ReadExisting();
                double roll = 0, pitch = 0, yaw = 0;
                int count = 0;
                List<string> dataParts = new List<string>();

                // GUI elemanlarına erişim için Invoke kullanılması
                Invoke(new Action(() =>
                {
                    if (!graphOpen) { txtReceive.AppendText(receivedData);}
                    else if (graphOpen) {
                        zaman += 0.05;


                        dataParts.AddRange(receivedData.Split(','));

                        
                        switch (count) { 
                            case 0:
                                double.TryParse(dataParts[0], out roll);
                                listPointsRoll.Add(new PointPair(zaman, roll));
                                count++;
                                 break;
                            case 1:
                                double.TryParse(dataParts[0], out pitch);
                                listPointsPitch.Add(new PointPair(zaman, pitch));
                                count++; break;
                            case 2:
                                double.TryParse(dataParts[0], out yaw);
                                listPointsYaw.Add(new PointPair(zaman, yaw));
                                count = 0; break;
                            default:
                                //listPointsRoll.Add(new PointPair(zaman, roll));
                                count = 0; break;
                        }
                                             
                        myPaneSicaklik.XAxis.Scale.Max = zaman;
                        myPaneSicaklik.AxisChange();

                        zedGraphControl1.Refresh();
                    }
                }));
                                    
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(txtMessage.Text+Environment.NewLine);
                    txtMessage.Clear();
                }
            }
            catch
            (Exception ex)
            { MessageBox.Show("Veri gönderilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnSelect.Enabled = false;
            btnUpload.Enabled = false;
            btnSend.Enabled = false;


            try
            {
                // Portu kapatmak için başka bir thread oluştur
                Thread closeThread = new Thread(ClosePort);
                closeThread.Start();
                //serialPort1.Close();
                serialPort1.DiscardInBuffer();
            }
            catch
            (Exception ex)
            { MessageBox.Show("Port kapanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);  }

            cboBaudrate.Enabled = true;
            cboBit.Enabled = true;
            cboPort.Enabled = true;
            checkEven.Enabled = true;
            checkOdd.Enabled = true;
            checkNone.Enabled = true;
        }

        private void ClosePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!btnSend.Enabled) {
                btnSend.Enabled = true;
                txtMessage.ForeColor = Color.Black;
                txtMessage.Font = new Font(txtReceive.Font, FontStyle.Regular);
            }
            txtReceive.Clear();
            txtMessage.Clear();
        }

        private void checkNone_CheckedChanged(object sender, EventArgs e)
        {

            if (checkNone.Checked && !serialPort1.IsOpen)
            {

                checkEven.Checked = false;
                checkOdd.Checked = false;
                checkNone.Checked = true;
            }
        }

        private void checkOdd_CheckedChanged(object sender, EventArgs e)
        {

            if (checkOdd.Checked && !serialPort1.IsOpen)
            {
                checkNone.Checked = false;
                checkEven.Checked = false;
                checkOdd.Checked = true;
            }

        }

        private void checkEven_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEven.Checked && !serialPort1.IsOpen)
            {
                checkNone.Checked = false;
                checkOdd.Checked = false;
                checkEven.Checked = true;
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hex Files (*.hex)|*.hex|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    slcFile.Text = openFileDialog.FileName;
                    btnUpload.Enabled = true;
                                                         
                    MessageBox.Show("Hex dosyası başarıyla içe aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya içe aktarılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcessHexContent(string hexContent)
        {
            txtMessage.ForeColor = Color.Green;
            txtMessage.Font = new Font(txtReceive.Font, FontStyle.Italic);
            txtMessage.Text = "Bootloader yükleniyor.." + Environment.NewLine + hexContent + Environment.NewLine + "Dosya sonu!!" + Environment.NewLine;
            //satır satır gönderilecek
            serialPort1.WriteLine(hexContent);
            btnSend.Enabled = false;
            // Burada hex içeriğini işleyebilirsiniz.
            // Örneğin: Verileri okuyup işleyebilir veya başka bir işlem yapabilirsiniz.
            // İçeriğin yapısına ve ne yapmak istediğinize bağlı olarak bu fonksiyonu doldurmalısınız.
            // Örneğin: MessageBox.Show(hexContent); gibi bir işlem yerine gerçek işlemleri eklemelisiniz.
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Hex içeriğini işleme al
            // Dosyayı oku
            try
            {
                string hexContent = File.ReadAllText(slcFile.Text);
                ProcessHexContent(hexContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya gönderilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUpload.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Mevcut seri portları temizle
            cboPort.Items.Clear();

            // Tüm seri portları al
            string[] ports = SerialPort.GetPortNames();

            // Seri portları listeye ekle
            foreach (string port in ports)
            {
                cboPort.Items.Add(port);
            }

            // İlk seri portu varsayılan olarak seç
            if (cboPort.Items.Count > 0)
            {
                cboPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Seri port bulunamadı.");
            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            graphOpen = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            graphOpen = false;
        }
    }
}
