using testXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace testXamarin.Core
{
    public class FillModels
    {
        public static List<SubjectModel> fillWinterSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            subjectModels.Add(new SubjectModel("Predmet winter 1", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 2", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 3", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 4", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 5", "5,0", "3", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 6", "5,0", "3", "Winter"));
                                                        
            subjectModels.Add(new SubjectModel("Predmet winter 7", "5,0", "1", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 8", "5,0", "1", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 9", "6,0", "1", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 10", "5,0", "1", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 11", "9,0", "1", "Winter"));
                                                        
            subjectModels.Add(new SubjectModel("Predmet winter 12", "5,0", "2", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 13", "5,0", "2", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 14", "5,0", "2", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 15", "5,0", "2", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 16", "5,0", "2", "Winter"));
            subjectModels.Add(new SubjectModel("Predmet winter 17", "5,0", "2", "Winter"));

            return subjectModels;

        }
        public static List<SubjectModel> fillSummerSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            subjectModels.Add(new SubjectModel("Predmet summer 1", "5,0", "3", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 2", "15,0", "3", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 3", "10,0", "3", "Summer"));
                                                        
            subjectModels.Add(new SubjectModel("Predmet summer 4", "10,0", "1", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 5", "5,0", "1", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 6", "5,0", "1", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 7", "5,0", "1", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 8", "5,0", "1", "Summer"));
                                                        
            subjectModels.Add(new SubjectModel("Predmet summer 9", "5,0", "2", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 10", "5,0", "2", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 11", "5,0", "2", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 12", "5,0", "2", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 13", "5,0", "2", "Summer"));
            subjectModels.Add(new SubjectModel("Predmet summer 14", "5,0", "2", "Summer"));

            return subjectModels;
        }
    }
}
