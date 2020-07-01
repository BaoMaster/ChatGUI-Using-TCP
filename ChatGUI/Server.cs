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
using System.Net;

namespace ChatGUI
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        Socket socServer, socClient;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            socServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, (int)numServerPort.Value);
            socServer.Bind(ip);
            socServer.Listen(3);
            socServer.BeginAccept(new AsyncCallback(xuLyKetNoi),null);
            CapNhatTrangThai("Waiting for connect ...");
        }
        byte[] data = new byte[1024];
        private void xuLyKetNoi(IAsyncResult ar)
        {
            socClient = socServer.EndAccept(ar);
            lbTrangThai.Invoke(new CapNhatGUI(CapNhatTrangThai), new object[] { "Connected!!! " });
            socClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xuLyDuLieuNhanDuoc), null);
        }

        private void xuLyDuLieuNhanDuoc(IAsyncResult ar)
        {
            int size=socClient.EndReceive(ar);
            string s = Encoding.ASCII.GetString(data, 0, size);
            txtNdChat.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new object[] { "Client: " + s });
            socClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xuLyDuLieuNhanDuoc),null);
        }

        delegate void CapNhatGUI(string s);
        void CapNhatTrangThai(string s)
        {
            lbTrangThai.Text = s;
        }
        void CapNhatNoiDungChat(string s)
        {
            txtNdChat.Text += s + "\r\n";
        }

        private void butGui_Click(object sender, EventArgs e)
        {
            socClient.Send(Encoding.ASCII.GetBytes(txtThongDiep.Text));
            CapNhatNoiDungChat("Server: " + txtThongDiep.Text);
            txtThongDiep.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
