namespace Expense_Tracker___Remodel.Tab_Panels
{
    partial class Category
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureButton3 = new CustomControls.PictureButton();
            this.pictureButton1 = new CustomControls.PictureButton();
            this.pictureButton2 = new CustomControls.PictureButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(1081, 637);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(61, 47);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 597);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 49);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureButton3);
            this.panel2.Controls.Add(this.pictureButton1);
            this.panel2.Controls.Add(this.pictureButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1104, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 49);
            this.panel2.TabIndex = 0;
            // 
            // pictureButton3
            // 
            this.pictureButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureButton3.IsBordered = false;
            this.pictureButton3.Location = new System.Drawing.Point(-3, 0);
            this.pictureButton3.Name = "pictureButton3";
            this.pictureButton3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureButton3.Picture = global::Expense_Tracker___Remodel.Properties.Resources.setting;
            this.pictureButton3.Size = new System.Drawing.Size(59, 49);
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
            this.pictureButton1.Size = new System.Drawing.Size(42, 49);
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
            this.pictureButton2.Size = new System.Drawing.Size(42, 49);
            this.pictureButton2.TabIndex = 1;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1200, 720);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.PictureButton pictureButton1;
        private CustomControls.PictureButton pictureButton2;
        private CustomControls.PictureButton pictureButton3;
    }
}
