using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class LoanListFrame : Form
    {
        private bool isNew = true;
        public LoanListFrame()
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
            idatetxt.Text = DateTime.Now.ToString();
            ddatetxt.Text = DateTime.Now.ToString();
            rdatetxt.Text = "";
            finetxt.Text = "";
            statustxt.Text = "";
            llTable.ClearSelection();
        }

        private void LoanListFrame_Load(object sender, EventArgs e)
        {
            LoadLoanListFrame();
        }

        private void LoadLoanListFrame()
        {
            string query = "SELECT * from IssueBook";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where IssueBook.studentName like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            llTable.AutoGenerateColumns = false;
            llTable.DataSource = dt;
            llTable.Refresh();
            llTable.ClearSelection();

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
            statustxt.Text = dt.Rows[0]["status"].ToString();
            finetxt.Text = dt.Rows[0]["fine"].ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "UPDATE Book SET Quantity =  Quantity + 1  WHERE BookId = '" + bidtxt.Text + "' ; Delete from IssueBook Where loanId = '" + lidtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Deleted & Updated");
                this.LoadLoanListFrame();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadLoanListFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadLoanListFrame();
        }

        private bool checkBook()
        {
            string query = ("Select * from Book where bookId = '" + bidtxt.Text + "' AND Book.quantity > 0");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkBalance()
        {
            string query = ("Select * from Student where studentId = '" + sidtxt.Text + "' AND Student.balance >= 0");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string loanId = this.lidtxt.Text;
            string bookId = this.bidtxt.Text;
            string sname = this.snametxt.Text;
            string sid = this.sidtxt.Text;
            string issueDate = this.idatetxt.Text;
            string dueDate = this.ddatetxt.Text;
            string returnDate = this.rdatetxt.Text;
            string status = this.statustxt.Text;
            string fine = Convert.ToString(this.finetxt.Text);

            if (string.IsNullOrEmpty(loanId) || string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(sname) || string.IsNullOrEmpty(sid) || string.IsNullOrEmpty(issueDate) || string.IsNullOrEmpty(dueDate)) //" + status + "  //|| string.IsNullOrEmpty(status)
            {
                MessageBox.Show("Invalid Information");
                return;
            }

            /*if (statustxt.Text.Equals("Issued"))
            {
                status = this.statustxt.Text;
            }
            else
            {
                MessageBox.Show("Invalid Status");
                return;
            }*/

            if (isNew == true)
            {
                if(checkBook())
                {
                    if(checkBalance())
                    {
                        string query1 = "INSERT into IssueBook(loanId,bookId,studentName,studentId,issueDate,dueDate,status,returnDate,fine) Values('" + loanId + "', '" + bookId + "', '" + sname + "', '" + sid + "', '" + issueDate + "','" + dueDate + "', 'Issued', NULL, 0) ; UPDATE Book SET Quantity =  Quantity - 1  WHERE BookId = '" + bidtxt.Text + "'";

                        if (DatabaseConnection.ExecuteQuery(query1) != true)
                        {
                            MessageBox.Show("Cannot Issue Book, Invalid Information");
                            return;
                        }

                        string query2 = "INSERT into History(fine,loanId,bookId,studentId,dueDate,returnDate) Values (" + fine + ", '" + loanId + "', '" + bookId + "', '" + sid + "','" + dueDate + "', '" + returnDate + "')";
                        DatabaseConnection.ExecuteQuery(query2);

                        MessageBox.Show("Book Issued Successfully");

                        this.LoadLoanListFrame();
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance");
                        return;
                    } 
                }
                else
                {
                    MessageBox.Show("Book is not Available");
                    return;
                } 
            }
            else
            {
                string query3 = "UPDATE IssueBook SET StudentName = '" + sname + "', BookId = '" + bookId + "', StudentId = '" + sid + "', IssueDate = '" + issueDate + "', DueDate = '" + dueDate + "', ReturnDate = '" + returnDate + "', Status = '" + status + "', Fine = '" + fine + "' WHERE LoanId = '" + lidtxt.Text + "'";
                DatabaseConnection.ExecuteQuery(query3);

                MessageBox.Show("IssueBook Updated Successfully");

                this.LoadLoanListFrame();
                this.Refresh();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            this.Visible = false;
            ah.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void llTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = llTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lidtxt.Text = id;
                this.LoadSingleList();
            }
        }

        private void LoanListFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
