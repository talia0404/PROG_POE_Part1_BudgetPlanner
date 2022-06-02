using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_Part1_BudgetPlanner
{
    //abstract class
    abstract class Expense
    {
       //declare field
        private double loanRepayment;
        private double loanRepaymentFull;

        //empty constrcutor
        public Expense()
        {

        }

        protected Expense(double loanRepayment, double loanRepaymentFull)
        {
            this.loanRepayment = loanRepayment;
            this.loanRepaymentFull = loanRepaymentFull;
        }



        //set and get methods
        public double LoanRepayment { get => loanRepayment; set => loanRepayment = value; }
        public double LoanRepaymentFull { get => loanRepaymentFull; set => loanRepaymentFull = value; }
    }
}
