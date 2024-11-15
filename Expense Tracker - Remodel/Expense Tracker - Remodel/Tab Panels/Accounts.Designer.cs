namespace Expense_Tracker___Remodel.Tab_Panels
{
    partial class Accounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureButton3 = new CustomControls.PictureButton();
            this.pictureButton1 = new CustomControls.PictureButton();
            this.pictureButton2 = new CustomControls.PictureButton();
            this.pictureButton4 = new CustomControls.PictureButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1200, 658);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 658);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 62);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1154, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureButton4);
            this.panel3.Controls.Add(this.pictureButton3);
            this.panel3.Controls.Add(this.pictureButton1);
            this.panel3.Controls.Add(this.pictureButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1021, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 62);
            this.panel3.TabIndex = 1;
            // 
            // pictureButton3
            // 
            this.pictureButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureButton3.IsBordered = false;
            this.pictureButton3.Location = new System.Drawing.Point(120, 0);
            this.pictureButton3.Name = "pictureButton3";
            this.pictureButton3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureButton3.Picture = global::Expense_Tracker___Remodel.Properties.Resources.setting;
            this.pictureButton3.Size = new System.Drawing.Size(59, 62);
            this.pictureButton3.TabIndex = 2;
            this.pictureButton3.Click += new System.EventHandler(this.pictureButton3_Click);
            // 
            // pictureButton1
            // 
            this.pictureButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureButton1.IsBordered = false;
            this.pictureButton1.Location = new System.Drawing.Point(42, 0);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureButton1.Picture = global::Expense_Tracker___Remodel.Properties.Resources.minus;
            this.pictureButton1.Size = new System.Drawing.Size(42, 62);
            this.pictureButton1.TabIndex = 1;
            // 
            // pictureButton2
            // 
            this.pictureButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureButton2.IsBordered = false;
            this.pictureButton2.Location = new System.Drawing.Point(0, 0);
            this.pictureButton2.Name = "pictureButton2";
            this.pictureButton2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureButton2.Picture = global::Expense_Tracker___Remodel.Properties.Resources.plus_symbol_button;
            this.pictureButton2.Size = new System.Drawing.Size(42, 62);
            this.pictureButton2.TabIndex = 1;
            // 
            // pictureButton4
            // 
            this.pictureButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureButton4.IsBordered = false;
            this.pictureButton4.Location = new System.Drawing.Point(84, 0);
            this.pictureButton4.Name = "pictureButton4";
            this.pictureButton4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureButton4.Picture = global::Expense_Tracker___Remodel.Properties.Resources.funnel;
            this.pictureButton4.Size = new System.Drawing.Size(42, 62);
            this.pictureButton4.TabIndex = 3;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Accounts";
            this.Size = new System.Drawing.Size(1200, 720);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.PictureButton pictureButton3;
        private CustomControls.PictureButton pictureButton1;
        private CustomControls.PictureButton pictureButton2;
        private CustomControls.PictureButton pictureButton4;
    }
}
