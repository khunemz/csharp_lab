using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public abstract class GradeTracker : object, IGradeTracker
    {
        protected List<float> grades;
        protected string _name;
        public NameChangedDelegate NameChanged;
        public string Name
        {
            get { return _name.ToUpper(); }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name cannot be empty");
                }
                _name = value;
            }
        }
        
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrade(TextWriter destination);
        public abstract IEnumerator GetEnumerator();

    }
}
