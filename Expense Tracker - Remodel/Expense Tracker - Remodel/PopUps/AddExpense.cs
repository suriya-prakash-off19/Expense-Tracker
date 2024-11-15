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
    public partial class AddExpense : UserControl
    {
        public event EventHandler ExpenseAdded;
        public AddExpense()
        {
            InitializeComponent();
            comboBox1.DataSource = DataManager.CategoryCollection.Keys.ToList();
        }
        private List<string> categoryList;
        public decimal ExpenseValue { get; private set; }
        public string ExpenseName { get; private set; }
        public string ExpenseCategory { get; private set; }
        public DateTime ExpenseDate { get; private set; }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseName = textBox1.Text;
                ExpenseValue = Convert.ToDecimal(textBox3.Text);
                ExpenseCategory = comboBox1.SelectedItem.ToString();
                ExpenseDate = dateTimePicker1.Value;
                if (ExpenseName == "" || ExpenseValue < 0)
                    throw new Exception();
                ExpenseAdded?.Invoke(this, e);
                this.ParentForm.Close();
            }
            catch
            {
                Warning.Visible = true;
            }

        }

        private void CloseBrnClick(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }
    }
}
