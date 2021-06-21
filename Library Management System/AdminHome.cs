using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminHome : Form
    {
        public static string x, y;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void msBtn_Click(object sender, EventArgs e)
        {
            AdminFrame af = new AdminFrame();
            this.Visible = false;
            af.Visible = true;
        }

        private void mbBtn_Click(object sender, EventArgs e)
        {
            BookFrame bf = new BookFrame();
            this.Visible = false;
            bf.Visible = true;
        }

        private void mllBtn_Click(object sender, EventArgs e)
        {
            LoanListFrame llf = new LoanListFrame();
            this.Visible = false;
            llf.Visible = true;
        }

        private void cpBtn_Click(object sender, EventArgs e)
        {
            PasswordFrame pf = new PasswordFrame();
            pf.Show(this);
            this.Hide();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            HistoryFrame hf = new HistoryFrame();
            this.Visible = false;
            hf.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            y = Form1.b;
        }
    }
}
