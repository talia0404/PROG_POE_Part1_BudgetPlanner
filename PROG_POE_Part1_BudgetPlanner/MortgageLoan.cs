using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_Part1_BudgetPlanner
{
    //inherits from Expense class
    class MortgageLoan :Expense
    {
        public double RepaymentFull(double Deposit, double PurchasePrice, double Interest, double Months)
        {
            //Calculating full home loan repayment
            //Formula: A=P*(1+i*n)

            //Subtract deposit from puchase price because that is already paid
            //Multiply by interest rate and divide by period of time amount should be paid in
            LoanRepaymentFull = (PurchasePrice - Deposit)* ((1.00 + (Interest/100.00)) * (Months/12.00));

            //Returns final value
            return LoanRepaymentFull;
        }
        public double MonthlyRepayment(double Deposit, double PurchasePrice, double Interest, double Months)
        {
            //Calculating monthly home loan repayment
            //Formula: A=P*(1+i*n)

            //Subtract deposit from puchase price because that is already paid
            //Multiply by interest rate and divide by period of time amount should be paid in
            LoanRepayment = ((PurchasePrice - Deposit) *( (1.00 + (Interest / 100.00) )* (Months / 12.00)))/Months;

            //Returns final value
            return LoanRepayment;
        }
    }
}
/*Referencing:
             * Date: NA
             * Website Name: Calculations using simple and compound interest by Siyavula
             * URL:https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03
             */