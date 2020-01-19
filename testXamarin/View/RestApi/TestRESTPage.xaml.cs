using testXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin.View.RestApi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestRESTPage : ContentPage
    {
        ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
        public TestRESTPage()
        {
            InitializeComponent();
            this.BindingContext = Employees;
        }

        private async void Display20_Clicked(object sender, EventArgs e)
        {
            //var employees = await Controllers.EmployeeREST.GetEmployes("http://10.0.2.2:3000/api/employee");
            var employees = await Controllers.EmployeeREST.GetEmployes("http://dummy.restapiexample.com/api/v1/employees");


            Employees = new ObservableCollection<Employee>();

            for (int i = Math.Max(0, employees.Count - 20); i < employees.Count; ++i)
            {
                Employees.Add(employees[i]);
            }
            EmployeesList.ItemsSource = Employees;
        }

        private async void DisplayNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());

        }
    }
}