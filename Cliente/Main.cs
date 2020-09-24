using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Main : Form
    {
        private Socket sck;
        public Main()
        {
            InitializeComponent();
            sck=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            sck.Connect("127.0.0.1",8);
            MessageBox.Show("connected");
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var s = sck.Send(Encoding.Default.GetBytes(TxbTexto.Text));

            if (s > 0)
            {
                MessageBox.Show("Data sent");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            sck.Close();
            sck.Dispose();
            Close();
        }
    }
}
