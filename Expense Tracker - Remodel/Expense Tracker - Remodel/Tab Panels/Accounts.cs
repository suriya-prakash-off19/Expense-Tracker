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
    public partial class Accounts : UserControl
    {
        public Accounts()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataSource.AccountsTable;
        }

        private void pictureButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
