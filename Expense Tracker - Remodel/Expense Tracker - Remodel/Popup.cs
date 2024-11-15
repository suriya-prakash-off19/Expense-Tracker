using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker___Remodel
{
    public partial class Popup : Form
    {
        public Popup(UserControl userControl)
        {
            InitializeComponent();
            userControl.Dock = DockStyle.Fill;
            Controls.Add(userControl);
        }
    }
}
