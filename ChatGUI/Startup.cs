using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGUI
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioSer.Checked)
            {
                Server frm = new Server();
                frm.ShowDialog();
               
            }
            else
            {
                Client frm = new Client();
                frm.ShowDialog();
                
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
