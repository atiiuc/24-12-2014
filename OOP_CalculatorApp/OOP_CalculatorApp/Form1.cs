using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calc = new Calculator();
        private void button1_Click(object sender, EventArgs e)
        {
            ////Calculator addition=new Calculator();
            //addition.firstNum = Convert.ToInt32(fText.Text);
            //addition.secondNum = Convert.ToInt32(sText.Text);
            double first = Convert.ToDouble(fText.Text);
            double second = Convert.ToDouble(sText.Text);
            calc.AddNum(first, second);
            rText.Text = Convert.ToString(calc.result);
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            //Calculator subtraction = new Calculator();
            double first = Convert.ToDouble(fText.Text);
            double second = Convert.ToDouble(sText.Text);
            //subtraction.firstNum = Convert.ToInt32(fText.Text);
            //subtraction.secondNum = Convert.ToInt32(sText.Text);
            calc.SubtractNum(first,second);
            rText.Text = Convert.ToString(calc.result);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            ////Calculator multiplication = new Calculator();
            double first = Convert.ToDouble(fText.Text);
            double second = Convert.ToDouble(sText.Text);
            ////multiplication.firstNum = Convert.ToInt32(fText.Text);
            ////multiplication.secondNum = Convert.ToInt32(sText.Text);
            calc.MultipyNum(first, second);
            rText.Text = Convert.ToString(calc.result);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            ////Calculator division = new Calculator();
            double first = Convert.ToInt32(fText.Text);
            double second = Convert.ToInt32(sText.Text);
            ////  division.firstNum = Convert.ToInt32(fText.Text);
            ////division.secondNum =Convert.ToInt32(sText.Text);
            calc.DivideNum(first, second);
            rText.Text = Convert.ToString(calc.result);
    
        }
    }
}
