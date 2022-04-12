using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Expenselt
{

    /// <summary>
    /// Interaction logic for ExpenseltHome.xaml
    /// </summary>
    public partial class ExpenseltHome : Window
    {
        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }
        public DateTime LastChecked { get; set; }
        public ExpenseltHome()
        {
            InitializeComponent();
            MainCaptionText = "View Expense Report ::";
            LastChecked = DateTime.Now;
            this.DataContext = this;
           
            ExpenseDataSource = new List<Person>()
            
{
new Person()
{
Name="Mike",
Department ="Legal",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
}
},
new Person()
{
Name ="Lisa",
Department ="Marketing",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
}
},
new Person()
{
Name="John",
Department ="Engineering",
Expense = new List<Expense>()

{
new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
new Expense() { ExpenseType="Software", ExpenseAmount=500 }
}
},
new Person()
{
Name="Mary",
Department ="Finance",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
},
new Person()
{
Name="James",
Department ="Programming",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
},
new Person()
{
Name="David",
Department ="Recruiting",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
},
new Person()
{
Name="Theo",
Department ="Marketing",
Expense = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
}
};

        }

        private void peopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ExpenseReport window = new ExpenseReport();
            //this.Width = window.Width;
            //this.Height = window.Height;
            //window.Show();
            //this.Close();

            
            ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            this.Width = expenseReport.Width;
            this.Height = expenseReport.Height;
            expenseReport.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            Person person =(Person)peopleListBox.SelectedItem;
            greetingMsg = person.Name;
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
