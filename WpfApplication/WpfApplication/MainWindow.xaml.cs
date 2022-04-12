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
using Stanislava_Georgieva_36_501219056_ex_3;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            tboxfirstName.Text = String.Empty;
            tboxsirName.Text = String.Empty;
            tboxlastName.Text = String.Empty;
            tboxfaculty.Text = String.Empty;
            tboxspecialty.Text = String.Empty;
            tboxOKS.Text = String.Empty;
            tboxFNumber.Text = String.Empty;
            tboxstatus.Text = String.Empty;
            tboxCourse.Text = String.Empty;
            tboxflow.Text = String.Empty;
            tboxgroup.Text = String.Empty;



        }
        private void Button_Disable(object sender, RoutedEventArgs e)
        {
            tboxfirstName.IsEnabled = false;
            tboxsirName.IsEnabled = false;
            tboxlastName.IsEnabled = false;
            tboxfaculty.IsEnabled = false;
            tboxspecialty.IsEnabled =false;
            tboxOKS.IsEnabled = false;
            tboxFNumber.IsEnabled = false;
            tboxstatus.IsEnabled = false;
            tboxCourse.IsEnabled = false;
            tboxflow.IsEnabled = false;
            tboxgroup.IsEnabled = false;
        }
        private void Button_Enable(object sender, RoutedEventArgs e)
        {
                   tboxfirstName.IsEnabled = true;
                   tboxsirName.IsEnabled = true;
                   tboxlastName.IsEnabled = true;
                   tboxfaculty.IsEnabled = true;
                   tboxspecialty.IsEnabled = true;
                   tboxOKS.IsEnabled =true;
                   tboxFNumber.IsEnabled = true;
                   tboxstatus.IsEnabled = true;
                   tboxCourse.IsEnabled = true;
                   tboxflow.IsEnabled = true;
                   tboxgroup.IsEnabled = true; 
        }
        private void Button_Display(object sender, RoutedEventArgs e)
        {
            StudentData st = new StudentData();
            st.SetDataToStudent();
            tboxfirstName.Text = st.getFirstName();
            tboxsirName.Text = st.getSirName();
            
            tboxlastName.Text = st.getLastName();
            tboxfaculty.Text = st.getFaculty();
            tboxspecialty.Text = st.getSpecialty();
            tboxFNumber.Text = st.getFNumber();
            tboxstatus.Text = st.getStatus();
            tboxCourse.Text = st.getCourse();
            tboxflow.Text = st.getFlow();
            tboxgroup.Text = st.getGroup();
            tboxOKS.Text = st.getOKS();
            

        }

        private void Button_Text(object sender, RoutedEventArgs e)
        {
            StudentData st = new StudentData();
            Student student = st.SetDataToStudent();
            //Student student = null;
            if(student == null)
            {
                tboxfirstName.Text = String.Empty;
                tboxsirName.Text = String.Empty;
                tboxlastName.Text = String.Empty;
                tboxfaculty.Text = String.Empty;
                tboxspecialty.Text = String.Empty;
                tboxOKS.Text = String.Empty;
                tboxFNumber.Text = String.Empty;
                tboxstatus.Text = String.Empty;
                tboxCourse.Text = String.Empty;
                tboxflow.Text = String.Empty;
                tboxgroup.Text = String.Empty;


                tboxfirstName.IsEnabled = false;
                tboxsirName.IsEnabled = false;
                tboxlastName.IsEnabled = false;
                tboxfaculty.IsEnabled = false;
                tboxspecialty.IsEnabled = false;
                tboxOKS.IsEnabled = false;
                tboxFNumber.IsEnabled = false;
                tboxstatus.IsEnabled = false;
                tboxCourse.IsEnabled = false;
                tboxflow.IsEnabled = false;
                tboxgroup.IsEnabled = false;

            }
            else
            {
                tboxfirstName.Text = st.getFirstName();
                tboxsirName.Text = st.getSirName();

                tboxlastName.Text = st.getLastName();
                tboxfaculty.Text = st.getFaculty();
                tboxspecialty.Text = st.getSpecialty();
                tboxFNumber.Text = st.getFNumber();
                tboxstatus.Text = st.getStatus();
                tboxCourse.Text = st.getCourse();
                tboxflow.Text = st.getFlow();
                tboxgroup.Text = st.getGroup();
                tboxOKS.Text = st.getOKS();
            }
        }
    }
}
