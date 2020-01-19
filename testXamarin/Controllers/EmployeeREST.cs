using Newtonsoft.Json;
using testXamarin.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace testXamarin.Controllers
{
    public class EmployeeREST
    {
        public static async Task<List<Employee>> GetEmployes(string url)
        {

            List<Employee> employees = new List<Employee>();

            HttpClient hc = new HttpClient();
            try
            {
                var response = await hc.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<Employee>>(content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return employees;
        }

        public static async Task CreateEmployees(Employee employee)
        {

            Uri uri = new Uri("http://dummy.restapiexample.com/api/v1/create");
            //node.js server
            HttpClient hc = new HttpClient();

            try
            {
                var json = JsonConvert.SerializeObject(employee);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = response = await hc.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\Employee successfully created.");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }
    }
}
