using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expense_Tracker___Remodel.Tab_Panels;
namespace Expense_Tracker___Remodel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControlLoad();
            DataSource.Dummy();
            menuTimer = new Timer()
            {
                Interval = 1
            };
            move = 1;
            menuTimer.Tick += MenuTimer_Tick;
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            panel1.Width += move;
            if(panel1.Width==170 && move==1)
            {
                move = -1;
                menuTimer.Stop();
            }
            else if(panel1.Width==70 && move==-1)
            {
                move = 1;
                menuTimer.Stop();
            }
        }

        private int move;
        private OverView overView;
        private Category category;
        private Accounts accounts;
        private Timer menuTimer;
        private void userControlLoad()
        {
            overView = new OverView();
            overView.Dock = DockStyle.Fill;
            overView.Hide();
            category = new Category();
            category.Dock = DockStyle.Fill;
            category.Hide();
            accounts = new Accounts();
            accounts.Dock = DockStyle.Fill;
            accounts.Hide();
            panel2.Controls.Add(accounts);
            panel2.Controls.Add(category);
            panel2.Controls.Add(overView);
        }

        private void pictureButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnOverView.IsSelected = true;

        }

        private void BtnOverView_Click(object sender, EventArgs e)
        {
            category.Hide();
            accounts.Hide();
            overView.Show();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            category.Show();
            accounts.Hide();
            overView.Hide();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            category.Hide();
            accounts.Show();
            overView.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!menuTimer.Enabled)
                menuTimer.Start();
        }
    }
}
