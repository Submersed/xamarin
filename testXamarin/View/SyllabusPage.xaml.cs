using testXamarin.Data;
using testXamarin.Model;
using testXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SyllabusPage : ContentPage
    {
        public SyllabusPage()
        {
            InitializeComponent();
            YearSubjects yearSubjects = new YearSubjects();

            Summer.ItemsSource = FillIt("Summer").Result;
            Winter.ItemsSource = FillIt("Winter").Result;

        }

        private static async Task<List<SubjectModel>> FillIt(string semester)
        {
            return await DBHelper.GetSubjects(semester);
        }
    }
}