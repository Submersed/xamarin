using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace testXamarin.Model
{
    [Serializable]
    public class Employee
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("employee_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EmployeeName { get; set; }
        [JsonProperty("employee_salary", NullValueHandling = NullValueHandling.Ignore)]
        public double EmployeeSalary { get; set; }
        [JsonProperty("employee_age", NullValueHandling = NullValueHandling.Ignore)]
        public int EmployeeAge { get; set; }
        [JsonProperty("profile_image", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileImage { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("salary", NullValueHandling = NullValueHandling.Ignore)]

        public double Salary { get; set; }
        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]

        public int Age { get; set; }


        public Employee() { }
    }
}
