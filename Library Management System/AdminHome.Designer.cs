namespace Library_Management_System
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.historyBtn = new System.Windows.Forms.Button();
            this.msBtn = new System.Windows.Forms.Button();
            this.mbBtn = new System.Windows.Forms.Button();
            this.mllBtn = new System.Windows.Forms.Button();
            this.cpBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.historyBtn);
            this.panel1.Controls.Add(this.msBtn);
            this.panel1.Controls.Add(this.mbBtn);
            this.panel1.Controls.Add(this.mllBtn);
            this.panel1.Controls.Add(this.cpBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 365);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.ADHome;
            this.pictureBox1.Location = new System.Drawing.Point(17, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(370, 193);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(171, 30);
            this.historyBtn.TabIndex = 28;
            this.historyBtn.TabStop = false;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // msBtn
            // 
            this.msBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.msBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBtn.Location = new System.Drawing.Point(270, 92);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(171, 30);
            this.msBtn.TabIndex = 27;
            this.msBtn.TabStop = false;
            this.msBtn.Text = "Manage Student";
            this.msBtn.UseVisualStyleBackColor = false;
            this.msBtn.Click += new System.EventHandler(this.msBtn_Click);
            // 
            // mbBtn
            // 
            this.mbBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.mbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mbBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbBtn.Location = new System.Drawing.Point(471, 92);
            this.mbBtn.Name = "mbBtn";
            this.mbBtn.Size = new System.Drawing.Size(171, 30);
            this.mbBtn.TabIndex = 26;
            this.mbBtn.TabStop = false;
            this.mbBtn.Text = "Manage Book";
            this.mbBtn.UseVisualStyleBackColor = false;
            this.mbBtn.Click += new System.EventHandler(this.mbBtn_Click);
            // 
            // mllBtn
            // 
            this.mllBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.mllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mllBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mllBtn.Location = new System.Drawing.Point(270, 143);
            this.mllBtn.Name = "mllBtn";
            this.mllBtn.Size = new System.Drawing.Size(171, 30);
            this.mllBtn.TabIndex = 25;
            this.mllBtn.TabStop = false;
            this.mllBtn.Text = "Manage Loan List";
            this.mllBtn.UseVisualStyleBackColor = false;
            this.mllBtn.Click += new System.EventHandler(this.mllBtn_Click);
            // 
            // cpBtn
            // 
            this.cpBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.cpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cpBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpBtn.Location = new System.Drawing.Point(471, 143);
            this.cpBtn.Name = "cpBtn";
            this.cpBtn.Size = new System.Drawing.Size(171, 30);
            this.cpBtn.TabIndex = 24;
            this.cpBtn.TabStop = false;
            this.cpBtn.Text = "Change Password";
            this.cpBtn.UseVisualStyleBackColor = false;
            this.cpBtn.Click += new System.EventHandler(this.cpBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(370, 240);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(171, 30);
            this.logoutBtn.TabIndex = 23;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(709, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button msBtn;
        private System.Windows.Forms.Button mbBtn;
        private System.Windows.Forms.Button mllBtn;
        private System.Windows.Forms.Button cpBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}