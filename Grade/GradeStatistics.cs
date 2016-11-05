namespace Grade
{
    public class GradeStatistics
    {
        public float averageGrade;
        public float highestGrade;
        public float lowestGrade;
        public GradeStatistics()
        {
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }

        public string Description {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;

                }

                return result; 
            }

            set
            {
                
            }
        }

        public string LetterGrade {
            get
            {
                string result;
                if (averageGrade >= 90)
                {
                    result = "A";
                }
                else if (averageGrade >= 80)
                {
                    result = "B";
                }
                else if (averageGrade >= 70)
                {
                    result = "C";
                }
                else if (averageGrade >=60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
                
            }
            set
            {

            }
        }

        public static void ComputeStatistics()
        {

        }
    }
}