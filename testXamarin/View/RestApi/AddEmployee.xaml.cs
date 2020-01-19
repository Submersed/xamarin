using testXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin.View.RestApi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployee : ContentPage
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = Name.Text;
            employee.Age = int.Parse(Age.Text);
            employee.Salary = double.Parse(Salary.Text);
            //employee.ProfileImage = "";
            await Controllers.EmployeeREST.CreateEmployees(employee);
        }
    }
}