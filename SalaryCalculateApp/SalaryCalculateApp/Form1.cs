using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        Employee aEmployee=new Employee();
        private void button1_Click(object sender, EventArgs e)
        {
            aEmployee.name = nameText.Text;
            aEmployee.house_rent = Convert.ToInt32(rentText.Text);
            aEmployee.medical_allowance = Convert.ToInt32(allowanceText.Text);
            aEmployee.basic_amount = Convert.ToInt32(basicText.Text);
            aEmployee.GetHouseRent(aEmployee.house_rent);
            aEmployee.GetMedicalAllowance(aEmployee.medical_allowance);
            aEmployee.GetTotalSalary();
            MessageBox.Show(aEmployee.name + " your salary will be " + aEmployee.GetTotalSalary()+"taka");
        }
    }
}
