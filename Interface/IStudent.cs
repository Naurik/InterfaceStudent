using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IStudent
    {
        string GetName { get; }
        int GetPaymentStudy { get; }
        int GetYearStudy { get; }
        int GetRating { get; }
    }
}
