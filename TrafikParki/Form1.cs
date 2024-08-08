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
using System.Reflection.Emit;

namespace TrafikParki
{
    public partial class Form1 : Form
    {

        private DateTime datetime, datetime2;
        private string rx_received;
        int puan = 0;

        string[] portlar = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void btn_Baglan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = txt_seriPort.Text;
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_Durdur_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }

            rx_received = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));

        }

        private void displaydata_event(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            datetime = DateTime.Now;
            datetime2 = DateTime.Today;

            string time2 = datetime2.Day + ":" + datetime2.Month + ":" + datetime2.Year;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            txt_Veriler.AppendText("Tarih : " + time2 + "      Saat : " + time + "     Gelen Veri : " + rx_received + "\n");

            string[] veriListesi = rx_received.Split('*');

            if (veriListesi[0] == "Kirmizi" && veriListesi[2] == "Var\r")
            {
                puan = puan - 50;
            }

            else if (veriListesi[0] == "Yesil" && veriListesi[2] == "Var\r")
            {
                puan = puan + 50;
            }

            label2.Text = puan.ToString();
        }

        private void txt_Veriler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            char[] buff = new char[1];
            buff[0] = e.KeyChar;
            serialPort1.Write(buff, 0, 1);
            e.Handled = true;
        }
    }
}