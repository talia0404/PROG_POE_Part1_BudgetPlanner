﻿//Student Number: ST10083706

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PROG_POE_Part1_BudgetPlanner
{
    public delegate void ExpenseExceedDelegate(double GrossIncome, double Groceries,
        double Water, double Travel, double Phone, double Other, double Tax);
    //Main class
    public partial class frmBudgetPlanner : Form
    {
        public frmBudgetPlanner()
        {
            InitializeComponent();
        }

        //Ensures correct components relevant to choice chosen in the comcobox appear/dissapear
        private void cmbChooseHousing_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays input components if the Rent option is chosen
            if (cmbChooseHousing.SelectedItem == "Renting.")
            {
                //Makes relevant components visible
                lblEnter.Visible = true;
                lblRentAmount.Visible = true;
                udRentAmount.Visible = true;
                btnClearRent.Visible = true;
                btnComplete.Visible = true;

                //Changes home loan button text to display rent
                btnCalculateHL.Text = "Display rent.";

                //Makes relevent components invisible
                lblPurchasePrice.Visible = false;
                udPurchasePrice.Visible = false;
                lblDeposit.Visible = false;
                udDeposit.Visible = false;
                lblInterest.Visible = false;
                udInterest.Visible = false;
                lblRepay.Visible = false;
                udRepayMonths.Visible = false;
                redDisplay.Visible = false;
                
                //Output component will remain clear
               redDisplay.Clear();
            }
            else
            {
                //Displays input components if Buying a Property option is chosen
                if (cmbChooseHousing.SelectedItem == "Buying a property.")
                {
                    //Makes relevant components visible
                    lblEnter.Visible = true;
                    btnClearHomeLoan.Visible = true;
                    lblPurchasePrice.Visible = true;
                    udPurchasePrice.Visible = true;
                    lblDeposit.Visible = true;
                    udDeposit.Visible = true;
                    lblInterest.Visible = true;
                    udInterest.Visible = true;
                    lblRepay.Visible = true;
                    udRepayMonths.Visible = true;
                    btnComplete.Visible = true;

                    //Makes relevant components invisible
                    lblRentAmount.Visible = false;
                    udRentAmount.Visible = false;
                    btnCalculateHL.Visible = false;
                    redDisplay.Visible = false;

                    btnCalculateHL.Text = "Calculate home loan repayment.";

                    //Output component will remain clear
                    redDisplay.Clear();
                }
            }
        }

        //Method to make display components invisible so input can be validated before calculated
        private void InvisibleDisplay()
        {
            //Makes display components invisible so input can be validated before calculated
            btnCalculateHL.Visible = false;
            btnExpenses.Visible = false;
            btnVehicle.Visible = false;
            redDisplay.Visible = false;
            //Output component will remain clear
            redDisplay.Clear();

        }

        //Validation button
        //Ensures that all input values are logical and have the correct inputs
        private void btnComplete_Click(object sender, EventArgs e)
        {
           
            //Ensures that valid housing option is given
            if ((cmbChooseHousing.SelectedItem != "Renting.") && (cmbChooseHousing.SelectedItem != "Buying a property."))
            {

                //Displays error message to user if input is inavalid 
                MessageBox.Show("Please choose valid housing option.");

                //Calls method to make components invisible so input can be validated before calculated
                InvisibleDisplay();
            }
            else

            {
                //Ensures that user can calculate amounts if correct value is given
                btnCalculateHL.Visible = true;
                btnExpenses.Visible = true;
                btnVehicle.Visible = true;
                redDisplay.Visible = true;
            }

            //Ensures that property values are valid if buying a property is chosen
            if (cmbChooseHousing.SelectedItem == "Buying a property.")
            {
                //Ensures that user will not be able to enter a deposit value that is equal to or higher than the purchase price for housing option
                if (udDeposit.Value >= udPurchasePrice.Value)
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Error message informs user to input valid deposit amount
                    MessageBox.Show("Deposit amount cannot be higher or equal to than the purchase price." +
                        "\nPlease enter valid amount.");

                }

                //Ensures user enters valid interest value for housing option
                if (udInterest.Value > 100)
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Error message informs user to input valid interest rate
                    MessageBox.Show("Interest rate cannot be higher than 100." +
                        "\nPlease enter valid rate.");

                    //Resets numericupDown value to 0
                    udInterest.Value = 0;

                }

                //Ensures that valid vehicle option is given
                if ((cmbVehicleChoice.SelectedItem != "Yes.") && (cmbVehicleChoice.SelectedItem != "No."))
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Displays error message to user if input is inavalid 
                    MessageBox.Show("Please choose a valid vehicle choice option.");

                }
                else

                {
                    //Ensures that user can calculate amounts if correct value is given
                    btnCalculateHL.Visible = true;
                    btnExpenses.Visible = true;
                    btnVehicle.Visible = true;
                    redDisplay.Visible = true;
                }

                //Ensures repayment months input number is valid- between 240 and 360 for housing option
                if ((udRepayMonths.Value < 240) || (udRepayMonths.Value > 360))
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Error message to inform user to enter correct number of months
                    MessageBox.Show("Invaldid number of months entered." +
                        "\nPlease input valid number of months - between 240 and 360.");
                }

            }
           
            //Validating vehicle related input amounts if user chooses to buy vehicle
            if (cmbVehicleChoice.SelectedItem == "Yes.")
            {
                //Ensures that user will not be able to enter a deposit value that is equal to or higher than the purchase price for vehicle option
                if (udVDeposit.Value > udVPurchasePrice.Value)
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Error message informs user to input valid deposit amount
                    MessageBox.Show("Deposit amount cannot be higher or equal to than the purchase price." +
                        "\nPlease enter valid amount.");
                }

                //Ensures user enters valid interest value for vehicle option
                if (udVRate.Value > 100)
                {
                    //Calls method to make components invisible so input can be validated before calculated
                    InvisibleDisplay();

                    //Error message informs user to input valid interest rate
                    MessageBox.Show("Interest rate cannot be higher than 100." +
                        "\nPlease enter valid rate.");

                    //Resets numericupDown value to 0
                    udVRate.Value = 0;
                }

            }

        }

        //Method created to make display components invisible so input can be validated before calculated
        //Makes validation button visible so inputs can be calculated
        private void udVisible()
        {
            btnCalculateHL.Visible = false;
            btnExpenses.Visible = false;
            btnVehicle.Visible = false;
            redDisplay.Visible = false;
            btnComplete.Visible = true;
            redDisplay.Clear();
        }

        private void udMonthlyIncome_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
              when numericUpDown value is changed */ 
            udVisible();
        }

        private void udGroceries_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udWaterLights_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udTravel_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();

        }

        private void udPhone_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udOtherEx_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udTax_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udPurchasePrice_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udRentAmount_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udDeposit_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udInterest_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        private void udRepayMonths_ValueChanged(object sender, EventArgs e)
        {
            /*Calls method to make display components invisible so input can be validated before calculated
             when numericUpDown value is changed */
            udVisible();
        }

        //Generic collection = List
        //Calculates sum of expenses
        public double SumOfExpenses(double groceries, double water, double travel, double phone, double other, double tax)
        {
            //Creating a list for expenses
            List<double> lstExpense = new List<double>();

            //Adding expense items to list
            lstExpense.AddRange(new double[] {groceries, water, travel,phone,other, tax});

            //Summing items in list
            double sum = lstExpense.Sum(j => Convert.ToDouble(j));

            return (sum);
        }

        public void ExpenceExceed(double grossIncome,double groceries, double water, double travel, double phone, double other, double tax)
        {
            double sum = SumOfExpenses(groceries, water, travel, phone, other, tax);
            double incomeExceed = grossIncome * (75 / 100);
            //string exceed = "";
            if (sum > incomeExceed)
            {
                MessageBox.Show( "Your income is higher than 75% of your gross monthly income.");
                
            }
            else
            {
                MessageBox.Show("Your income is not higher than 75% of your gross monthly income.");
            }
                
               
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Makes validation button invisible each time button is clicked
            btnComplete.Visible = false;

            //Declares variables and assigns expense related input values to them 
            //Converts input values to prefered datatype: double/real
            double grossIncome = decimal.ToDouble(udMonthlyIncome.Value);
            double groceries = decimal.ToDouble(udGroceries.Value);
            double water = decimal.ToDouble(udWaterLights.Value);
            double travel = decimal.ToDouble(udTravel.Value);
            double phone = decimal.ToDouble(udPhone.Value);
            double other = decimal.ToDouble(udOtherEx.Value);
            double tax = decimal.ToDouble(udTax.Value);

            //Declares variables and assigns property buying related input values to them 
            //Converts input values to prefered datatype: double/real
            double purchasePrice = decimal.ToDouble(udPurchasePrice.Value);
            double totaldeposit = decimal.ToDouble(udDeposit.Value);
            double interest = decimal.ToDouble(udInterest.Value);
            double repay = decimal.ToDouble(udRepayMonths.Value);

            //Declares variables and assigns input values to them 
            //Converts input values to prefered datatype: double/real
            //Stores full repayment value
            double RepaymentValue = 0.00;

            //Stores monthly repayment value
            double monthlyRepaymentValue = 0.00;

            //Stores monthly left over money after deducting expenses and repayment amounts
            double monthlyAvailableMoney = 0.00;

            //Declares variables and assigns vehicle related input values to them 
            string vModel = tbxModel.Text;
            string make = tbxMake.Text;

            //Converts input values to prefered datatype: double/real
            double vPurchasePrice = decimal.ToDouble(udVPurchasePrice.Value);
            double vDeposit = decimal.ToDouble(udVDeposit.Value);
            double vRate = decimal.ToDouble(udVRate.Value);
            double Premium = decimal.ToDouble(udPremium.Value);

            //Stores total Monthly Vehicle Repayment Cost
            double totalMonthlyVehicleRepaymentCost = 0.00;

            //Stores sum of array
            double sum = SumOfExpenses(groceries, water, travel, phone, other, tax);

            //Creating an instance of the MortgageLoan class 
            MortgageLoan mL = new MortgageLoan();

            //Calls the RepaymentFull method which calculates the full homeloan amount to be paid
            //Calculates the  home loan repayment
            RepaymentValue = mL.RepaymentFull(totaldeposit, purchasePrice, interest, repay);

            //Calls the monthlyRepaymentValue method which calculates the monthly homeloan amount required to be paid
            //Calculates the monthly home loan repayment
            monthlyRepaymentValue = mL.MonthlyRepayment(totaldeposit, purchasePrice, interest, repay);

            //Calculates the monthly available money
            monthlyAvailableMoney = grossIncome - (sum);



                if (cmbChooseHousing.SelectedItem == "Buying a Property.")
                {
                    //calculate a third of this months income
                    double third = grossIncome * (1.00 / 3.00);

                    //alerts user that home loan may not be approved 
                    if (monthlyRepaymentValue > third)
                    {
                        MessageBox.Show("Sorry, approval of the home loan looks unlikely.");
                    }

                    //Displays income, total expenses, monthly available amount, monthly repayment amaount, monthly repayment amount deducted from monthly available amount
                    redDisplay.Text = "You have chosen to buy a property. Your monthly home loan repayment amount is: R" +
                    Convert.ToString(monthlyRepaymentValue) + " and is likely to be approved." +
                    
                    //Displays gross income before deductions
                    "\n\nYour total expenses for the month including the home loan repayment is: R" +
                    Convert.ToString(sum + monthlyRepaymentValue) +
                    
                    //Displays gross income after deductions
                    "\n\nAvailable amount after deducting the home repayment is: R" +
                    Convert.ToString(monthlyAvailableMoney - monthlyRepaymentValue)
                    ;

            }
            else
            {
                //Displays relevant values if rent option is chosen
            if (cmbChooseHousing.SelectedItem == "Renting.")
            {
                //Informs user that calculation has already been done
                MessageBox.Show("Calculated in expense button.");

            }
            }

           
        }

        public class ExpenseDisplay
        {
            public string expense;
            public double amount;

            public ExpenseDisplay(string expense, double amount)
            {
                this.expense = expense;
                this.amount = amount;
            }

            public override string ToString()
            {
                return expense + ": R" + amount + "\n";
            }
        }

        public string DisplayExpense(double groceries, double water, double travel, double phone, double other, double tax)
        {
            List<ExpenseDisplay> ex = new List<ExpenseDisplay>();
            ex.Add(new ExpenseDisplay("Grocery costs", groceries));
            ex.Add(new ExpenseDisplay("Water and lights costs", water));
            ex.Add(new ExpenseDisplay("Travel costs", travel));
            ex.Add(new ExpenseDisplay("Telephone and cellphone costs", phone));
            ex.Add(new ExpenseDisplay("Other expense costs", other));
            ex.Add(new ExpenseDisplay("Tax", tax));

            var sortedList = ex.OrderByDescending(x => x.expense).ToList();

            string displaySorted = Convert.ToString(String.Join("", sortedList));

            return displaySorted;
        }

        //Calculate and display expense
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            //Makes validation button invisible each time button is clicked
            btnComplete.Visible = false;

            //Declares variables and assigns expense related input values to them 
            //Converts input values to prefered datatype: double/real
            double grossIncome = decimal.ToDouble(udMonthlyIncome.Value);
            double groceries = decimal.ToDouble(udGroceries.Value);
            double water = decimal.ToDouble(udWaterLights.Value);
            double travel = decimal.ToDouble(udTravel.Value);
            double phone = decimal.ToDouble(udPhone.Value);
            double other = decimal.ToDouble(udOtherEx.Value);
            double tax = decimal.ToDouble(udTax.Value);

            //Declares variables and assigns expense/rent irelated nput values to them 
            //Converts input values to prefered datatype: double/real
            double rent = decimal.ToDouble(udRentAmount.Value);

            //Stores monthly left over money after deducting expenses and repayment amounts
            double monthlyAvailableMoney = 0.00;

            //Stores sum of array
            double sum = SumOfExpenses(groceries, water, travel, phone, other, tax);

            frmBudgetPlanner f = new frmBudgetPlanner();

            ExpenseExceedDelegate exD = new ExpenseExceedDelegate(f.ExpenceExceed);

            exD(grossIncome, groceries, water, travel, phone, other, tax);

            //Calculates the monthly available money
            monthlyAvailableMoney = grossIncome - (sum);

                //Calculates the monthly available amount by subtracting the sum of the expenses from the gross income
                monthlyAvailableMoney = grossIncome - (sum);

            string displaySorted = DisplayExpense(groceries, water, travel, phone, other, tax);

            //Displays output if rent is chosen
            if (cmbChooseHousing.SelectedItem == "Renting.")
            {
                redDisplay.Text = "Your total expenses for the month excluding the rent expense is: R" +
              Convert.ToString(sum)+
              "\n\nYour total expenses for the month incuding the rent expense is: R" +
                Convert.ToString(sum + rent) +

                //Displays gross income before deductions
               "\n\nAvailable amount before deducting the rent expense is: R" +
               Convert.ToString(monthlyAvailableMoney) +

                //Displays gross income after deductions
               "\n\nAvailable amount after deducting the rent expense is: R" +
               Convert.ToString(monthlyAvailableMoney - rent)+
               "\n"+displaySorted;

            }
            else
            {
                //Displays output if rent is not chosen
                redDisplay.Text = "Your total expenses for the month excluding the rent expense is: R" +
                              Convert.ToString(sum)+
                              "\n\nAvailable amount before deductions is: R" +
               Convert.ToString(monthlyAvailableMoney) +
               "\n" + displaySorted;

            }



        }


        //Clears all monthly expenditure values
        private void btnClearExpenses_Click(object sender, EventArgs e)
        {
            udGroceries.Value = 0;
            udWaterLights.Value = 0;
            udTravel.Value = 0;
            udPhone.Value = 0;
            udOtherEx.Value = 0;
        }

        //Clears rent amount
        private void btnClearRent_Click(object sender, EventArgs e)
        {
            udRentAmount.Value = 0;
        }

        //Clears all property related amounnts
        private void btnClearHomeLoan_Click(object sender, EventArgs e)
        {
            udPurchasePrice.Value = 0;
            udDeposit.Value = 0;
            udInterest.Value = 0;
            udRepayMonths.Value = 0;
        }

        //Clears all values
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears input amounnts
            udMonthlyIncome.Value = 0;
            udTax.Value = 0;
            udGroceries.Value = 0;
            udWaterLights.Value = 0;
            udTravel.Value = 0;
            udPhone.Value = 0;
            udOtherEx.Value = 0;
            udRentAmount.Value = 0;
            udPurchasePrice.Value = 0;
            udDeposit.Value = 0;
            udInterest.Value = 0;
            udRepayMonths.Value = 240;
            cmbChooseHousing.Text = "";

            //Clears richTextBox
            redDisplay.Clear();
            //Makes calculate button and richTextBox invisible so that inputs can be validated before anything is displayed
            btnCalculateHL.Visible = false;
            redDisplay.Visible = false;
            btnComplete.Visible = true;

            //Makes all renting and buying property relevant compononts invisible so that user can choose again
            lblEnter.Visible = false;
            btnClearHomeLoan.Visible = false;
            lblRentAmount.Visible = false;
            udRentAmount.Visible = false;
            lblPurchasePrice.Visible = false;
            udPurchasePrice.Visible = false;
            lblDeposit.Visible = false;
            udDeposit.Visible = false;
            lblInterest.Visible = false;
            udInterest.Visible = false;
            lblRepay.Visible = false;
            udRepayMonths.Visible = false;


        }

        //PART 2

        //Ensures correct components relevant to choice chosen in the comcobox appear/dissapear
        private void cmbVehicleChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleChoice.SelectedItem == "Yes.")
            {
                //Appropriate components relevent to purchasing a vehicle will be visible
                lblEnter2.Visible = true;
                lblModel.Visible = true;
                tbxModel.Visible = true;
                lblMake.Visible = true;
                tbxMake.Visible = true;
                lblVPurchasePrice.Visible = true;
                udVPurchasePrice.Visible = true;
                lblVDeposit.Visible = true;
                udVDeposit.Visible = true;
                lblVInterestRate.Visible = true;
                udVRate.Visible = true;
                lblPremium.Visible = true;
                udPremium.Visible = true;
                udVisible();

                //Output component will remain clear
                redDisplay.Clear();

            }
            else
            {
                if (cmbVehicleChoice.SelectedItem == "No.")
                {
                    //Appropriate components relevent to not purchasing a vehicle will be invisible
                    lblEnter2.Visible = false;
                    lblModel.Visible = false;
                    tbxModel.Visible = false;
                    lblMake.Visible = false;
                    tbxMake.Visible = false;
                    lblVPurchasePrice.Visible = false;
                    udVPurchasePrice.Visible = false;
                    lblVDeposit.Visible = false;
                    udVDeposit.Visible = false;
                    lblVInterestRate.Visible = false;
                    udVRate.Visible = false;
                    lblPremium.Visible = false;
                    udPremium.Visible = false;
                    udVisible();

                    //Output component will remain clear
                    redDisplay.Clear();

                    //Appropriate components will be cleared
                    tbxModel.Text="";
                    tbxMake.Text = "";
                    udVPurchasePrice.Value = 0;
                    udVDeposit.Value = 0;
                    udVRate.Value = 0;
                    udPremium.Value = 0;

                }
            }
        }


        //Display vehicle repayment details
        private void btnVehicle_Click(object sender, EventArgs e)
        {

            //Makes validation button invisible each time button is clicked
            btnComplete.Visible = false;

            //Declares variables and assigns vehicle related input values to them 
            string vModel = tbxModel.Text;
            string make = tbxMake.Text;

            //Converts input values to prefered datatype: double/real
            double vPurchasePrice = decimal.ToDouble(udVPurchasePrice.Value);
            double vDeposit = decimal.ToDouble(udVDeposit.Value);
            double vRate = decimal.ToDouble(udVRate.Value);
            double Premium = decimal.ToDouble(udPremium.Value);

            //Stores total Monthly Vehicle Repayment Cost
            double totalMonthlyVehicleRepaymentCost = 0.00;

            //Creating an instance of the VehicleCalculation class
            VehicleCalculation vc = new VehicleCalculation();

            //Calls method from vehicle class to calculate repayment amount
            totalMonthlyVehicleRepaymentCost = vc.monthlyVehicleCost(vDeposit, vPurchasePrice, vRate, Premium);

            //Dipsplays repayment details if vehicle is chosen
            if (cmbVehicleChoice.SelectedItem == "Yes.")
            {
                redDisplay.Text = "\nYou have chosen to buy a vehicle. The vehicle model is " + tbxModel +
                    " and the make is " + tbxMake + "." +
                    "The total monthly repayment is R" + Convert.ToString(totalMonthlyVehicleRepaymentCost);

            }
            else
            {
                //Informs user that they have chosen to not buy a vehicle
                redDisplay.Text = "You have chosen to not purchase a vehicle.";
            }
        }






        /*Referencing:
         * Date:NA
         * Website Name:How to Convert int to String with Sample Code - C# ... by eduCBA
         * URL:https://www.educba.com/convert-int-to-string-c-sharp/
         */

        /*Referencing:
          * Date:  30 Jan, 2019
          * Website Name:Decimal.ToInt32() Method in C#, GeeksforGeeks
          * URL: https://www.geeksforgeeks.org/decimal-toint32-method-in-c-sharp/ 
          */

        /*Referencing:
         * Date: 23 Feb 2020
         * Website Name:Populating an array by ScriptingMaster
         * URL:http://www.scriptingmaster.com/javascript/populating-array.asp#:~:text=To%20populate%20an%20array%20with,URLsArray%20%3D%20new%20Array%20(4)%3B
         */


        /*Referencing:
         * Date:31 Oct 2018
         * Website Name:How to sum up an array of integers in C# by Stack Overflow
         * URL: https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
         */

    }


}

