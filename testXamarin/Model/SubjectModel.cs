using System;
using System.Collections.Generic;
using System.Text;

namespace testXamarin.Model
{
    public class SubjectModel
    {
        public string Subject { get; set; }
        public string ECTS { get; set; }
        public string Letnik { get; set; }
        public string Semester { get; set; }


        public SubjectModel()
        { }
        public SubjectModel(string Subject, string ECTS,string Letnik,string Semester)
        {
            this.ECTS = ECTS;
            this.Subject = Subject;
            this.Letnik = Letnik;
            this.Semester = Semester;
        }
    }
}
