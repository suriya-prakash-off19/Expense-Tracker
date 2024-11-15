using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker___Remodel
{
    internal static class DataSource
    {
        static DataSource()
        {
            SetCategoryTable();
            SetAccountTable();
            SetExpensePieTable();
            SetIncomePieTable();
        }

        public static void Dummy()
        {

        }
        public static DataTable CategoryTable { get; set; }
        public static DataTable AccountsTable { get; set; }
        public static DataTable ExpensePieTable { get; set; }
        public static DataTable IncomePieTable { get; set; }

        private static void SetIncomePieTable()
        {
            IncomePieTable = new DataTable();
            IncomePieTable.Columns.Add("Name", typeof(string));
            IncomePieTable.Columns.Add("Color", typeof(string));
            IncomePieTable.Columns.Add("Percentage", typeof(string));
        }

        private static void SetExpensePieTable()
        {
            ExpensePieTable = new DataTable();
            ExpensePieTable.Columns.Add("Name");
            ExpensePieTable.Columns.Add("Color");
            ExpensePieTable.Columns.Add("Percentage");
        }

        private static void SetAccountTable()
        {
            AccountsTable = new DataTable();
            AccountsTable.Columns.Add("Id");
            AccountsTable.Columns.Add("Name");
            AccountsTable.Columns.Add("Amount");
            AccountsTable.Columns.Add("Category");
            AccountsTable.Columns.Add("Type");
            AccountsTable.Columns.Add("Date");
        }

        private static void SetCategoryTable()
        {
            CategoryTable = new DataTable();
            CategoryTable.Columns.Add("Category Name");
            CategoryTable.Columns.Add("Category Color");
            CategoryTable.Columns.Add("Category Type");
        }


        // Category Reset
        public static void ResetCategoryTable()
        {
            CategoryTable.Rows.Clear();
            foreach(var name in DataManager.CategoryCollection.Keys)
            {
                CategoryTable.Rows.Add(new object[]
                {
                    name,
                    DataManager.CategoryCollection[name].CategoryColor,
                    DataManager.CategoryCollection[name].CategoryType.ToString()
                });
            }
        }

        //Category Type filter
        public static void FilterCategoryTable(CategoryType type)
        {
            CategoryTable.Rows.Clear();
            foreach (var name in DataManager.CategoryCollection.Keys)
            {
                if (DataManager.CategoryCollection[name].CategoryType==type)
                {
                    CategoryTable.Rows.Add(new object[]
                    {
                        name,
                        DataManager.CategoryCollection[name].CategoryColor,
                        DataManager.CategoryCollection[name].CategoryType.ToString()
                    });
                }
            }
        }

        //Category Remove
        public static void RemoveFromCategoryTable(string name)
        {
            foreach(DataRow rows in CategoryTable.Rows)
            {
                if((string)rows["Category Name"]==name)
                {
                    CategoryTable.Rows.Remove(rows);
                    DataManager.CategoryCollection.Remove(name);
                    return;
                }
            }
        }

        //Accounts Reset
        public static void ResetAccountsTable()
        {
            AccountsTable.Rows.Clear();
            foreach(var id in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[id];
                AccountsTable.Rows.Add(new object[]
                {
                    data.AccountsId,
                    data.AccountsName,
                    data.AccountsAmount.ToString(),
                    data.AccountsCategory.CategoryName,
                    data.AccountsCategory.CategoryType.ToString(),
                    data.AccountsDate.Date.ToString()
                });
            }
        }

        //Account Filter
        public static void FilterAccountsTable(DateTime date,bool isDaily,AccountsFilterType type)
        {
            AccountsTable.Rows.Clear();
            foreach (var id in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[id];
                if (CompareDates(isDaily, data.AccountsDate.Date, date))
                {
                    if ((type==AccountsFilterType.Income && data.AccountsCategory.CategoryType==CategoryType.Expense)|| (type == AccountsFilterType.Expense && data.AccountsCategory.CategoryType == CategoryType.Income))
                    {
                        continue;
                    }
                    AccountsTable.Rows.Add(new object[]
                    {
                        data.AccountsId,
                        data.AccountsName,
                        data.AccountsAmount.ToString(),
                        data.AccountsCategory.CategoryName,
                        data.AccountsCategory.CategoryType.ToString(),
                        data.AccountsDate.Date.ToString()
                    });
                }
            }

        }

        //Account Remove
        public static void RemoveFromAccountsTable(int id)
        {
            foreach(DataRow rows in AccountsTable.Rows)
            {
                if((int)rows["Id"]==id)
                {
                    AccountsTable.Rows.Remove(rows);
                    DataManager.AccountsCollection.Remove(id);
                    return;
                }
            }
        }

        //ExpensePieReset
        public static void ExpensePieReset(DateTime date,bool isDaily)
        {
            ExpensePieTable.Rows.Clear();
            float tot = 0;
            Dictionary<string, float> pairs = new Dictionary<string, float>();
            foreach (var x in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[x];
                if (CompareDates(isDaily, date, data.AccountsDate) && data.AccountsCategory.CategoryType == CategoryType.Expense)
                {
                    if (!pairs.ContainsKey(data.AccountsCategory.CategoryName))
                    {
                        pairs.Add(data.AccountsCategory.CategoryName, 0);
                    }
                    pairs[data.AccountsCategory.CategoryName] += data.AccountsAmount;
                    tot += data.AccountsAmount;
                }
            }
            List<string> names = new List<string>();
            foreach(var x in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[x];
                if(CompareDates(isDaily,date,data.AccountsDate)&&data.AccountsCategory.CategoryType==CategoryType.Expense && !names.Contains(data.AccountsCategory.CategoryName))
                {
                    ExpensePieTable.Rows.Add(new object[]
                    {
                        data.AccountsCategory.CategoryName,
                        data.AccountsCategory.CategoryColor,
                        pairs[data.AccountsCategory.CategoryName]/tot*100
                    });
                    names.Add(data.AccountsCategory.CategoryName);
                }
            }
        }
        
        //ExpensePieReset
        public static void IncomePieReset(DateTime date,bool isDaily)
        {
            ExpensePieTable.Rows.Clear();
            List<string> names = new List<string>();
            float tot = 0;
            Dictionary<string, float> pairs = new Dictionary<string, float>();
            foreach (var x in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[x];
                if (CompareDates(isDaily, date, data.AccountsDate) && data.AccountsCategory.CategoryType == CategoryType.Income)
                {
                    if(!pairs.ContainsKey(data.AccountsCategory.CategoryName))
                    {
                        pairs.Add(data.AccountsCategory.CategoryName, 0);
                    }
                    pairs[data.AccountsCategory.CategoryName] += data.AccountsAmount;
                    tot += data.AccountsAmount;
                }
            }
            foreach (var x in DataManager.AccountsCollection.Keys)
            {
                var data = DataManager.AccountsCollection[x];
                if(CompareDates(isDaily,date,data.AccountsDate)&&data.AccountsCategory.CategoryType==CategoryType.Income && !names.Contains(data.AccountsCategory.CategoryName))
                {
                    ExpensePieTable.Rows.Add(new object[]
                    {
                        data.AccountsCategory.CategoryName,
                        data.AccountsCategory.CategoryColor,
                        pairs[data.AccountsCategory.CategoryName]/tot*100
                    });
                    names.Add(data.AccountsCategory.CategoryName);
                }
            }
        }


        //Comapare dates
        private static bool CompareDates(bool isDaily, DateTime date1, DateTime date2)
        {
            if(isDaily)
            {
                return (date1.Date == date2.Date);
            }
            return (date1.Month == date2.Month && date1.Year == date2.Year);
        }
    }

    public enum AccountsFilterType
    {
        Income,
        Expense,
        Both
    }
}
