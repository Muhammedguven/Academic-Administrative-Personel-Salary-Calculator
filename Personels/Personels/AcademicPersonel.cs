using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personels
{
   public class AcademicPersonel : Personel
    {

    
        public double SalaryFactorAc = SalaryFactor;
        public int incentiveCoef;
        public override string PersonelGroup(string ptype)
        {
           
            return ptype;
        }
        public override double CalculateSalary(int numOfChildren, int degree, int step, string MaritalStatus)
        {
            AcademicPersonelForm apf = new AcademicPersonelForm();
            if (MaritalStatus == "Married")
            {
                SalaryFactorAc += +1;
            }
            if (numOfChildren == 1)
            {
                SalaryFactorAc += 1;
            }
            else if (numOfChildren > 1)
            {
                double a = Convert.ToInt32(numOfChildren);
                SalaryFactorAc += (a * 0.75);
            }

            if(incentiveCoef > 0)
                          {
                              SalaryFactorAc += (incentiveCoef * 0.65);

                          } 

            apf.label2.Text = Convert.ToString((BaseSalary * SalaryFactorAc) + (step * 10) + (degree * 15));

            double result = Convert.ToDouble(apf.label2.Text);
            return result;
        }


    }
}
