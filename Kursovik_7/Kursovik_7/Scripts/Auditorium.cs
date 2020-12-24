using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik_7
{
    [Serializable]
    class Auditorium
    {
        private int MaxDaysOnWeek = AppEnums.Days.Length;
        private int MaxLessonPerDay = AppEnums.LessonsTime.Length;
        // in our university 6 lessons is max for one day and education 6 day a weak 
         
        private SortedDictionary<int, string> AllLessons;
        public string AudID { get; set; }

        public Auditorium(string id)
        {
            AudID = id;
            AllLessons = new SortedDictionary<int, string>();
            for (int i = 0; i < MaxDaysOnWeek * MaxLessonPerDay; ++i)
                AllLessons.Add(i, "");
        }

        public string this[int i, int j]
        {
            get => AllLessons[i* MaxLessonPerDay + j];

            set
            {
                if (i* MaxLessonPerDay + j < AllLessons.Count())
                    AllLessons[i * MaxLessonPerDay + j] = value;
            }
        }


    }
}
