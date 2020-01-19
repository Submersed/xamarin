using testXamarin.Core;
using testXamarin.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace testXamarin.Data
{
    class DBHelper
    {
        public static string databaseFileName;
        private static void InitializeDB()
        {
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CanFindLocation");

            // Create the folder path.
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            databaseFileName = System.IO.Path.Combine(applicationFolderPath, "CanFindLocation.db");
            File.Create(databaseFileName);
        }

        public static void ResetDB()
        {
            InitializeDB();
            File.Delete(databaseFileName);
        }
        public static async void FillUsers()
        {
            if (File.Exists(databaseFileName))
            {
                using (SQLiteConnection conn = new SQLiteConnection(databaseFileName))
                {
                    conn.CreateTable<UserModel>();
                    conn.Insert(new UserModel("admin", "admin", "user0", "priimek0", "test@test.si", true));
                    conn.Insert(new UserModel("user", "user", "user1", "priimek1", "denis@test.si", false));
                }
            }
            else {
                InitializeDB();
            }



        }
        public static async void FillSubjects()
        {
            if (File.Exists(databaseFileName))
            {
                using (SQLiteConnection conn = new SQLiteConnection(databaseFileName))
                {
                    conn.CreateTable<SubjectModel>();
                    conn.InsertAll(FillModels.fillSummerSubjects());
                    conn.InsertAll(FillModels.fillWinterSubjects());
                    conn.Close();
                }
            }
            else
            {
                InitializeDB();
            }
        }

        public static async Task<List<SubjectModel>> GetSubjects(string semester)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(databaseFileName))
                {
                    var query = from SubjectModel in conn.Table<SubjectModel>()
                                where SubjectModel.Letnik == "3" && SubjectModel.Semester == semester
                                select SubjectModel;

                    return query.ToList();
                }

            }
            catch
            {
                return null;
            }
        }

        public static UserModel GetUser(string username, string password)
        {
            if (!File.Exists(databaseFileName))
            {
                InitializeDB();
                FillUsers();
                FillSubjects();
            }
            using (SQLiteConnection conn = new SQLiteConnection(databaseFileName))
            {
                var query = from UserModel in conn.Table<UserModel>()
                            where UserModel.Username == username && UserModel.Password == password
                            select UserModel;

                return query.FirstOrDefault();
            }
        }
    }
}
