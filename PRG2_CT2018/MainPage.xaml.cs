using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PRG2_CT2018
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Employee> employeeList = new List<Employee>(); // outside of MainPage() to allow other methods to access (qns 7)
        public MainPage()
        {
            this.InitializeComponent();

            // Question 7
            Employee employee1 = new FullTimeEmployee(103, "John", 1500.0, 100.0);
            Employee employee2 = new PartTimeEmployee(101, "Mary", 50.0, 10);
            Employee employee3 = new SalesEmployee(102, "Apple", 1000.0, 50.0, 10000.0);

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
        }

        public void IncreaseBasicPay()
        {
            foreach (Employee emp in employeeList)
            {
                if (emp is FullTimeEmployee)
                {
                    FullTimeEmployee e = (FullTimeEmployee) emp;
                    e.BasicPay *= 1.1;
                }
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(idTxt.Text);
            bool flag = false;
            resultTxt.Text = "";

            foreach(Employee emp in employeeList)
            {
                if(id == emp.Id)
                {
                    resultTxt.Text =  $"Name: {emp.Name}\nPay: {emp.CalculatePay()}";
                    flag = true;
                }
            }
            if (flag == false)
            {
                resultTxt.Text = "Id not found";
            }
        }

        private void IncreaseBtn_Click(object sender, RoutedEventArgs e)
        {
            // Increase basic pay by 10%
            IncreaseBasicPay();
        }
    }
}
