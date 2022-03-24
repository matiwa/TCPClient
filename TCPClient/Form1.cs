using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string host = textBox1.Text;
            int port = System.Convert.ToInt16(numericUpDown1.Value);
            try
            {
                TcpClient klient = new TcpClient(host, port);
                listBox1.Items.Add("Connected to" + host + ", on the port: " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Error: Connection failed!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
