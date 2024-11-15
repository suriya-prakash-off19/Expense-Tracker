using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker___Remodel
{
    public class CategoryData
    {
        public string CategoryName { get; set; }
        public CategoryType CategoryType { get; set; }
        public Color CategoryColor { get; set; }
    }

    public class AccountsData
    {
        public string AccountsName { get; set; }
        public int AccountsId { get; set; }
        public CategoryData AccountsCategory { get; set; }
        public DateTime AccountsDate { get; set; }
        public int AccountsAmount { get; set; }
    }


    public static class DataManager
    {
        static DataManager()
        {
            AccountsCollection = new Dictionary<int, AccountsData>();
            CategoryCollection = new Dictionary<string, CategoryData>();
            AccountIndex = 0;
            Currency = "$"; 
        }
        public static Dictionary<int,AccountsData> AccountsCollection { get; set; }
        public static Dictionary<string, CategoryData> CategoryCollection { get; set; }
        public static int AccountIndex { get; set; }
        public static string Currency { get; set; } 
    }


    public enum CategoryType
    {
        Income,
        Expense
    }
}
