using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  peopleListBox.Items.Add("James");
            //  peopleListBox.Items.Add("David ");

            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            james.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void btnGreetings_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
            //       string greetingMsg;
            //     greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            //   MessageBox.Show("Hi " + greetingMsg);
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            
            int size = 2;
            int txtboxLength = tboxfirstName.GetLineLength(0);
            Message.Text = DateTime.Now.ToString();
            if (txtboxLength > size)
            {
                MessageBox.Show("Hi this is your first Visual Studio application!" + tboxfirstName.Text);

            }
            else
            {
                MessageBox.Show("Edit text = " + tboxfirstName.Text);

            }
            
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(tboxNum.Text);
            double y = double.Parse(tboxY.Text);
            double res = Math.Pow(n, y);
            MessageBox.Show(res.ToString());
        }

        private void btnCalcFac_Click(object sender, RoutedEventArgs e)
        {
            int fact = 1;
            int n = int.Parse(tboxNum.Text);
            for(int i =1; i<=n; i++)
            {
                fact = fact * i;
            }
            MessageBox.Show(fact.ToString());

        }
    }
}
