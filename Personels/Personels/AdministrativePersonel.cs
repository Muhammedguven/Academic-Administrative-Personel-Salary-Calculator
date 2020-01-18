using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personels
{
    class AdministrativePersonel : Personel
    {
        public double SalaryFactorAd = SalaryFactor;
        public bool admDuty;
        public override string PersonelGroup(string ptype)
        {
            return ptype;
        }
        public override double CalculateSalary(int numOfChildren, int degree, int step, string MaritalStatus)
        {
           
            AdministrativePersonelForm apf = new AdministrativePersonelForm();

            if (MaritalStatus == "Married")
            {
                SalaryFactorAd += 1;
            }
            if (numOfChildren == 1)
            {
                SalaryFactorAd += 1;
            }
            else if (numOfChildren > 1)
            {
                double a = Convert.ToInt32(numOfChildren);
                SalaryFactorAd += (a * 0.75);
            }


            if (admDuty == true)
            {

                SalaryFactorAd += 1.5;

            }

            apf.label2.Text = Convert.ToString(BaseSalary * SalaryFactorAd + (step * 5) + (degree * 10));
            double result = Convert.ToDouble(apf.label2.Text);
            return result;
        }
    }
}
