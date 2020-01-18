using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personels
{
    public abstract class Personel
    {
        public const double BaseSalary = 2000;
        public const double SalaryFactor = 10;
        public abstract double CalculateSalary(int numOfChildren, int degree, int step, string MaritalStatus);
        public abstract string PersonelGroup(string ptype);



    }
 
}
