using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculateApp
{
    class Employee
    {
        public string name;
        public double basic_amount;
        public double house_rent;
        public double medical_allowance;

        public double GetHouseRent(double rent)
        {
            house_rent = (basic_amount*rent)/100;
            return house_rent;
        }
        public double GetMedicalAllowance(double allowance)
        {
            medical_allowance = (basic_amount * allowance) / 100;
            return medical_allowance;

        }
        public double GetTotalSalary()
        {
            return house_rent + medical_allowance + basic_amount;
        }

    }
}
