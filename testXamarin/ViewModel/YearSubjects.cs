using testXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace testXamarin.ViewModel
{
    public class YearSubjects
    {
        public List<SubjectModel> winterSemester { get; set; }
        public List<SubjectModel> SummerSemester { get; set; }

        public YearSubjects()
        {
            this.SummerSemester = fillSummerSubjects();
            this.winterSemester = fillWinterSubjects();
        }

        public List<SubjectModel> fillWinterSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            subjectModels.Add(new SubjectModel("Predmet winter 1", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 2", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 3", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 4", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 5", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 6", "5,0", "3", "Winter"));
            return subjectModels;

        }
        public List<SubjectModel> fillSummerSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            subjectModels.Add(new SubjectModel("Predmet summer 1", "5,0", "3", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 2", "15,0", "3", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 3", "10,0", "3", "Summer"));
            return subjectModels;
        }
    }
}
