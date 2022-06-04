using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_Part1_BudgetPlanner
{
    //inherits from Expense class
    class VehicleCalculation : Expense
    {
        //method calculates full monthly vehicle repayment cost
        public double monthlyVehicleCost(double Deposit, double PurchasePrice, double Interest, double Premium)
        {
            //Calculates total monthly vehicle cost 
            //Subtract deposit from puchase price because that is already paid
            //Multiply by interest rate and divide by period of time amount should be paid in
            VehicleTotalCost = ((PurchasePrice - Deposit) * Interest) / 72.00;

            //Returns final value
            return VehicleTotalCost;
        }

    }
}
