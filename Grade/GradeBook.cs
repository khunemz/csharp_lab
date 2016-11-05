using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook : GradeTracker
    {
        // State of data : propertities
        

        public override void WriteGrade(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public bool ThrowAwayLowest { get; set; }

        public GradeBook()
        {
            _name = "Empty name";
            this.grades = new List<float>();
        }

        // Behavior : methods
        public override void AddGrade(float grade)
        {
            //scope
            grades.Add(grade);
            
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            if (ThrowAwayLowest)
            {
                float sum = 0;
                foreach (var grade in grades)
                {
                    stats.highestGrade = Math.Max(grade, stats.highestGrade);
                    stats.lowestGrade = Math.Min(grade, stats.lowestGrade);
                    sum += grade;
                    stats.averageGrade = sum / grades.Count; // TODO : add DivideByZeros

                }
            }
            return stats;
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

    }
}
