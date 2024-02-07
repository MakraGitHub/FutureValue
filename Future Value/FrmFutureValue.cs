using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Value
{
    public partial class FrmFutureValue : Form
    {
        public FrmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            decimal monthylyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValue(
                monthylyInvestment, monthlyInterestRate, months
                );
            txtFutureValue.Text = futureValue.ToString("C");
            txtMonthlyInvestment.Focus();
        }

            private decimal CalculateFutureValue(decimal monthylyInvestment, decimal monthlyInterestRate,
               int months){

                decimal futureValue = 0m;

                for(int i = 0; i<months; i++){
                    futureValue =(futureValue + monthylyInvestment)
                        *(1 + monthlyInterestRate);
                }
                return futureValue;          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This is location change Event 
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }
 
    }
}
