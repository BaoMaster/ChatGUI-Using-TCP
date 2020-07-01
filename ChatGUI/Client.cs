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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket socClient;
        byte[] data = new byte[1024];
        private void butKetnoi_Click(object sender, EventArgs e)
        {
            socClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(txtSerIP.Text),(int)numSerPort.Value);
            socClient.BeginConnect(ip, new AsyncCallback(xuLyketNoi), null);
            socClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xuLyDuLieuNhanDuoc), null);
        }
        private void xuLyDuLieuNhanDuoc(IAsyncResult ar)
        {
            int size = socClient.EndReceive(ar);
            string s = Encoding.ASCII.GetString(data, 0, size);
            txtNdChat.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new object[] { "Server: " + s });
            socClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xuLyDuLieuNhanDuoc), null);
        }
        void CapNhatNoiDungChat(string s)
        {
            txtNdChat.Text += s + "\r\n";
        }

        private void xuLyketNoi(IAsyncResult ar)
        {
            socClient.EndConnect(ar);
            laTrangThai.Invoke(new CapNhatGUI(CapNhatTrangThai), new object[] { "Connected!!!" });
        }
        delegate void CapNhatGUI(string s);
        void CapNhatTrangThai(string s)
        {
            laTrangThai.Text = s;
        }

        private void butGui_Click(object sender, EventArgs e)
        {
            socClient.Send(Encoding.ASCII.GetBytes(txtThongDiep.Text));
            CapNhatNoiDungChat("Client: " + txtThongDiep.Text);
            txtThongDiep.Text = "";
        }
    }
}
