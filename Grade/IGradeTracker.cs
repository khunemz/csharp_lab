using System.IO;

namespace Grade
{
    public interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrade(TextWriter destination);
        string Name { get; set;  }
    }
}