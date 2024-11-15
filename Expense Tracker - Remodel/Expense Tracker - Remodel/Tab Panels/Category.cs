using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker___Remodel.Tab_Panels
{
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
            openTimer = new Timer()
            {
                Interval = 10
            };
            openTimer.Tick += OpenTimer_Tick;
            move = 1;
            dataGridView1.DataSource = DataSource.CategoryTable;
        }

        private int move;
        private void OpenTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += move;
            if(panel2.Width==140 && move==1)
            {
                move = -1;
                openTimer.Stop();
            }
            else if(panel2.Width==60 && move==-1)
            {
                move = 1;
                openTimer.Stop();
            }
        }

        private Timer openTimer;
        private void pictureButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureButton3_Click(object sender, EventArgs e)
        {
            if (!openTimer.Enabled)
                openTimer.Start();
        }
    }
}
