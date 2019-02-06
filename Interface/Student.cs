using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : IStudent
    {
        private string _name;
        private int _money;
        private int _yearsLearn;
        private int _ratings;

        public Student() { }
        public void Stud(string name, int money, int yearsLearn, int ratings)
        {
            _name = name;
            _money = money;
            _yearsLearn = yearsLearn;
            _ratings = ratings;
        }
        public void Name(string name)
        {
            _name = name;
        }

        #region Interface
        public string GetName { get { return _name; } }
        public int GetPaymentStudy { get { return _money; } }
        public int GetYearStudy { get { return _yearsLearn; } }
        public int GetRating { get { return _ratings; } }
        #endregion
    }
}
