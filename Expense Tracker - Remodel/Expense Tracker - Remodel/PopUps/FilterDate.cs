using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker___Remodel.PopUps
{
    public partial class FilterDate : UserControl
    {
        public FilterDate()
        {
            InitializeComponent();
            radioButton1.Select();
            isDaily = false;
        }

        private bool isDaily;
        private void button2_Click(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSource.IncomePieReset(dateTimePicker1.Value, isDaily);
            DataSource.ExpensePieReset(dateTimePicker1.Value, isDaily);
            ParentForm?.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            isDaily = false ;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            isDaily = true;
        }
    }
}
