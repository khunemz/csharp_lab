using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {

        private void giveBookAName (ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Just A GradeBook";
        }

        private void IncrementNumber ( int number)
        {
            number = number + 1;
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }


        [TestMethod]
        public void UsingArray()
        {
            float[] grades;
            grades = new float[3];
            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        
        [TestMethod]
        public void UppercaseString()
        {
            string name = "khunemz";
            name = name.ToUpper(); // Assign new string to old string

            Assert.AreEqual("KHUNEMZ", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015 ,1 ,1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }
        [TestMethod]
        public void ReferencesTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            giveBookAName(ref book2);
            Assert.AreEqual("Just A GradeBook", book2.Name);

        }
        [TestMethod]
        public void VariableHoldsAReferences()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Chutipong ";
            g1 = new GradeBook();
            Assert.AreNotEqual(g1.Name, g2.Name);
            Assert.AreEqual(g1.Name, null);
        }

        [TestMethod]
        public void IntVariableHoldsAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "khunemz";
            string name2 = "Khunemz";

            bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        
    }
}
