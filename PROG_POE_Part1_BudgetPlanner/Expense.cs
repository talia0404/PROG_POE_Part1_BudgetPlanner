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
        private int loanRepayment;
        private int loanRepaymentFull;

        //empty constrcutor
        public Expense()
        {

        }

        protected Expense(int loanRepayment, int loanRepaymentFull)
        {
            this.loanRepayment = loanRepayment;
            this.loanRepaymentFull = loanRepaymentFull;
        }



        //set and get methods
        public int LoanRepayment { get => loanRepayment; set => loanRepayment = value; }
        public int LoanRepaymentFull { get => loanRepaymentFull; set => loanRepaymentFull = value; }
    }
}
