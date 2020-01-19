using System;
using System.Collections.Generic;
using System.Text;

namespace testXamarin.Model
{
    class UserModel
    {
        public bool AreCredentialsInvalid { get; set; } = false;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }

        public UserModel()
        { }
        public UserModel(string username, string password, string name, string surname, string email, bool admin)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
            Admin = admin;
        }
    }
}
