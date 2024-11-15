namespace Expense_Tracker___Remodel
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAccount = new Expense_Tracker___Remodel.PictureTextButton();
            this.BtnCategory = new Expense_Tracker___Remodel.PictureTextButton();
            this.BtnOverView = new Expense_Tracker___Remodel.PictureTextButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnAccount);
            this.panel1.Controls.Add(this.BtnCategory);
            this.panel1.Controls.Add(this.BtnOverView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 859);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(69, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 859);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker___Remodel.Properties.Resources.list;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnAccount
            // 
            this.BtnAccount.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAccount.ButtonFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccount.ButtonImage = global::Expense_Tracker___Remodel.Properties.Resources.accounts;
            this.BtnAccount.ButtonName = "Accounts";
            this.BtnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccount.IsSelected = false;
            this.BtnAccount.Location = new System.Drawing.Point(3, 216);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAccount.Size = new System.Drawing.Size(157, 44);
            this.BtnAccount.TabIndex = 2;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCategory.ButtonFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.ButtonImage = global::Expense_Tracker___Remodel.Properties.Resources.categories;
            this.BtnCategory.ButtonName = "Category";
            this.BtnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategory.IsSelected = false;
            this.BtnCategory.Location = new System.Drawing.Point(3, 147);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCategory.Size = new System.Drawing.Size(157, 44);
            this.BtnCategory.TabIndex = 1;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnOverView
            // 
            this.BtnOverView.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOverView.ButtonFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOverView.ButtonImage = global::Expense_Tracker___Remodel.Properties.Resources.file;
            this.BtnOverView.ButtonName = "Overview";
            this.BtnOverView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOverView.IsSelected = false;
            this.BtnOverView.Location = new System.Drawing.Point(3, 82);
            this.BtnOverView.Name = "BtnOverView";
            this.BtnOverView.Padding = new System.Windows.Forms.Padding(5);
            this.BtnOverView.Size = new System.Drawing.Size(157, 44);
            this.BtnOverView.TabIndex = 0;
            this.BtnOverView.Click += new System.EventHandler(this.BtnOverView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 859);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private PictureTextButton BtnAccount;
        private PictureTextButton BtnCategory;
        private PictureTextButton BtnOverView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

