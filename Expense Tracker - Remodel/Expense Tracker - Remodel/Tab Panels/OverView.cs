using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expense_Tracker___Remodel.PopUps;
namespace Expense_Tracker___Remodel.Tab_Panels
{
    public partial class OverView : UserControl
    {

        public OverView()
        {
            InitializeComponent();
            panel1.Height = 55;
            panel1.Location = new Point( this.Width - panel1.Width, this.Height - panel1.Height);
            settingsTimer = new Timer()
            {
                Interval = 10
               
            };
            settingsTimer.Tick += SettingsTimer_Tick;
        }

        private void SettingsTimer_Tick(object sender, EventArgs e)
        {
            panel1.Height += move ;
            panel1.Location = new Point(this.Width - panel1.Width, this.Height - panel1.Height);
            if (move==1 & panel1.Height==110)
            {
                move = -1;
                settingsTimer.Stop();
            }
            else if(move==-1 && panel1.Height==55)
            {
                move = 1;
                settingsTimer.Stop();
            }
        }

        private int move=1;
        private Timer settingsTimer;
        
        private void pictureButton1_Click(object sender, EventArgs e)
        {
            FilterDate date = new FilterDate();
            BackGround bck = new BackGround();
            Popup popup = new Popup(date);
            bck.Show();
            popup.ShowDialog();
            bck.Close();
            bck.Dispose();
        }

        private void pictureButton2_Click(object sender, EventArgs e)
        {
            if (!settingsTimer.Enabled)
                settingsTimer.Start();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel2.Width = (int)(0.30 * Width);
            panel4.Height = (int)(0.45 * panel2.Height);
            panel5.Height = (int)(0.45 * panel2.Height);
        }
    }
}
