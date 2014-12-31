using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CalculatorApp
{
    class Calculator
    {
         //public double firstNum;
         //public double secondNum;
         public double result;

         public double AddNum(double firsttNum,double secondNum)
         {
             result=firsttNum + secondNum;
            return result;
        }
         public double SubtractNum(double firstNum, double secondNum)
        {
            result =firstNum - secondNum;
            return result;
        }
         public double MultipyNum(double firstNum, double secondNum)
        {
            result = firstNum * secondNum;
            return result;
        }
         public double DivideNum(double firstNum, double secondNum)
        {
            result = firstNum / secondNum;
            return result;
        }
    }
}
