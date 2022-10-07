using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise5_2
{
    public partial class FrmFutureValue : Form
    {
        public FrmFutureValue()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment =
                Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {

                futureValue = (futureValue + monthlyInvestment) 
                            * (1 + monthlyInterestRate);
            }   



            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateFutureValue(decimal monthlyInvestment,
            decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        private void ClearFutureValue(object sender, EventArgs e) 
        {
            txtFutureValue.Text = "";
        }
    }

    
}

