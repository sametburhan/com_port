using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_port
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            { MessageBox.Show(ex.Message, "Hiç com portu yok", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            btnClose.Enabled = false;
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cboPort.Text != "") {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
            try
            {
                serialPort1.PortName = cboPort.Text;
                serialPort1.BaudRate = int.Parse(cboBaudrate.Text);
                serialPort1.DataBits = int.Parse(cboBit.Text);
                if (checkEven.Checked) { serialPort1.Parity = Parity.Even; } else if(checkOdd.Checked){ serialPort1.Parity = Parity.Odd; } else { serialPort1.Parity = Parity.None; }
                serialPort1.Open();
            }
            catch
            (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            serialPort1.DataReceived += SerialPort_DataReceived;
            //txtReceive.AppendText(serialPort1.ReadExisting() + Environment.NewLine);//"sdjfkgos" + Environment.NewLine);

            cboBaudrate.Enabled = false;
            cboBit.Enabled = false;
            cboPort.Enabled = false;
            checkEven.Enabled = false;
            checkOdd.Enabled = false;
            checkNone.Enabled = false;

        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        if (serialPort1.IsOpen)
            {
            SerialPort serialPort = (SerialPort)sender;
            string receivedData = serialPort.ReadExisting();

            // GUI elemanlarına erişim için Invoke kullanılması
            Invoke(new Action(() =>
            {
                txtReceive.AppendText(receivedData);
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
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            try
            {
                serialPort1.Close();
            }
            catch
            (Exception ex)
            { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            cboBaudrate.Enabled = true;
            cboBit.Enabled = true;
            cboPort.Enabled = true;
            checkEven.Enabled = true;
            checkOdd.Enabled = true;
            checkNone.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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
    }
}
