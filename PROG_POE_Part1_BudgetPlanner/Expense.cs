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
        private double vehicleTotalCost;

        //empty constrcutor
        public Expense()
        {

        }

        protected Expense(double loanRepayment, double loanRepaymentFull)
        {
            this.loanRepayment = loanRepayment;
            this.loanRepaymentFull = loanRepaymentFull;
            this.vehicleTotalCost = vehicleTotalCost;
        }

        //set and get methods
        public double LoanRepayment { get => loanRepayment; set => loanRepayment = value; }
        public double LoanRepaymentFull { get => loanRepaymentFull; set => loanRepaymentFull = value; }
        public double VehicleTotalCost { get => vehicleTotalCost; set => vehicleTotalCost = value; }

    }
}
