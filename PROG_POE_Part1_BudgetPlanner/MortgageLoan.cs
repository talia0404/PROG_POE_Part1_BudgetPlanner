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
        public int RepaymentFull(int Deposit, int PurchasePrice, int Interest, int Months)
        {
            //Calculating full home loan repayment
            //Formula: A=P*(1+i*n)

            LoanRepaymentFull = (PurchasePrice -Deposit)* (1 + (Interest / 100) * (Months / 12));


            return LoanRepaymentFull;
        }
        public int MonthlyRepayment(int Deposit, int PurchasePrice, int Interest, int Months)
        {
            //Calculating monthly home loan repayment
            //Formula: A=P*(1+i*n)

            LoanRepayment = (PurchasePrice - Deposit) * (1 + (Interest / 100) * (Months / 12)/Months);

            return LoanRepayment;
        }
    }
}
/*Referencing:
             * Date: NA
             * Website Name: Calculations using simple and compound interest by Siyavula
             * URL:https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03
             */