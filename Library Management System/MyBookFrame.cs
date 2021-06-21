﻿using System;
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
    public partial class MyBookFrame : Form
    {
        private bool isNew = true;
        public static string x;
        public MyBookFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            lidtxt.Text = "";
            bidtxt.Text = "";
            snametxt.Text = "";
            sidtxt.Text = "";
            idatetxt.Text = "";
            ddatetxt.Text = "";
            rdatetxt.Text = "";
            finetxt.Text = "";
            mbTable.ClearSelection();
        }

        private void LoadMyBookFrame()
        {
            string query = "SELECT * from IssueBook where status = 'Issued' AND StudentId = '" + x + "'";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " AND IssueBook.studentName like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            mbTable.AutoGenerateColumns = false;
            mbTable.DataSource = dt;
            mbTable.Refresh();
            mbTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleList()
        {
            string query = "Select * from IssueBook Where loanId = '" + lidtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            lidtxt.Text = dt.Rows[0]["loanId"].ToString();
            bidtxt.Text = dt.Rows[0]["bookId"].ToString();
            snametxt.Text = dt.Rows[0]["studentName"].ToString();
            sidtxt.Text = dt.Rows[0]["studentId"].ToString();
            idatetxt.Text = dt.Rows[0]["issueDate"].ToString();
            ddatetxt.Text = dt.Rows[0]["dueDate"].ToString();
            rdatetxt.Text = dt.Rows[0]["returnDate"].ToString();
            finetxt.Text = dt.Rows[0]["fine"].ToString();
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadMyBookFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadMyBookFrame();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string loanId = this.lidtxt.Text;
            string bookId = this.bidtxt.Text;
            string sname = this.snametxt.Text;
            string sid = this.sidtxt.Text;
            string issueDate = this.idatetxt.Text;
            string dueDate = this.ddatetxt.Text;
            string returnDate = this.rdatetxt.Text;
            string fine = Convert.ToString(this.finetxt.Text);
            string status = "Returned";

            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "UPDATE IssueBook SET StudentName = '" + sname + "', BookId = '" + bookId + "', StudentId = '" + sid + "', IssueDate = '" + issueDate + "', DueDate = '" + dueDate + "', ReturnDate = '" + returnDate + "', Status = '" + status + "', Fine = '" + fine + "' WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE Book SET Quantity =  Quantity + 1  WHERE BookId = '" + bidtxt.Text + "' ; UPDATE History SET ReturnDate = '" + returnDate + "' WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE IssueBook SET fine = CASE when DATEDIFF(d,duedate,returndate)>0 then (DATEDIFF(d,duedate,returndate)) *10 else 0 end WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE History SET fine = CASE when DATEDIFF(d,duedate,returndate)>0 then (DATEDIFF(d,duedate,returndate)) *10 else 0 end WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE Student set Student.fine = IssueBook.fine from Student, IssueBook where Student.studentId = '" + sidtxt.Text + "' ; UPDATE Student set balance = balance - fine, fine = 0 Where StudentId = '" + sidtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Book Returned Successfully");
                this.LoadMyBookFrame();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Book Returned Failed");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentHome sh = new StudentHome();
            this.Visible = false;
            sh.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void MyBookFrame_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            LoadMyBookFrame();
        }

        private void MyBookFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = mbTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lidtxt.Text = id;
                this.LoadSingleList();
            }
        }
    }
}
