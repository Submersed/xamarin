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
    public partial class DisplayEmployee : ContentView
    {
        public DisplayEmployee()
        {

            InitializeComponent();
            getemployeesAsync();
        }

        public async Task getemployeesAsync()
        {
            var testis = Controllers.EmployeeREST.GetEmployes("http://dummy.restapiexample.com/api/v1/employees");
            test.ItemsSource = await testis;
        }
    }
}