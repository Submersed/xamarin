using testXamarin.Core;
using testXamarin.Data;
using testXamarin.Model;
using testXamarin.View.RestApi;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {


        public Login()
        {
            InitializeComponent();
            //BindingContext = loginM;
            UsernameEntry.Focus();
        }


        private async void AboutBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(1);

            UsernameEntry.Focus();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                await Navigation.PushAsync(new SyllabusPage());
            }
            else
            {
                validation.IsVisible = true;
            }
        }

        private async void CreateUsersBtn_Clicked(object sender, EventArgs e)
        {
            DBHelper.FillUsers();


        }

        private async void AddSubjectsBtn_Clicked(object sender, EventArgs e)
        {
            DBHelper.FillSubjects();


        }

        private bool UserValidation()
        {
            if (DBHelper.GetUser(this.UsernameEntry.Text, this.PasswordEntry.Text) != null)
            {
                return true;
            }
            return false;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var testis = Controllers.EmployeeREST.GetEmployes("http://dummy.restapiexample.com/api/v1/employees");
            await Navigation.PushAsync(new TestRESTPage());
        }
    }
}