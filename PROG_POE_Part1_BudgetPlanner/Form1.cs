//Student Number: ST10083706

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE_Part1_BudgetPlanner
{
    //Main class
    public partial class frmBudgetPlanner : Form
    {
        public frmBudgetPlanner()
        {
            InitializeComponent();
        }

       //Makes correct components relevant to choice chosen in the comcobox appear/dissapear
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
               
                //Makes relevent components invisible
                lblPurchasePrice.Visible = false;
                udPurchasePrice.Visible = false;
                lblDeposit.Visible = false;
                udDeposit.Visible = false;
                lblInterest.Visible = false;
                udInterest.Visible = false;
                lblRepay.Visible = false;
                udRepayMonths.Visible = false;
                btnCalculate.Visible = false;
                redDisplay.Visible = false;
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
                    btnCalculate.Visible = false;
                    redDisplay.Visible = false;
                }
            }
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

                //Makes display components false so that user can correct incorrect inputs before calculating amounts
                btnCalculate.Visible = false;
                redDisplay.Visible = false; 
            }
                else

               {
                //Ensures that user can calculate amounts if correct value is given
                    btnCalculate.Visible = true;
                    redDisplay.Visible = true;
                }

            //Ensures that property values are valid if buying a property is chosen
            if (cmbChooseHousing.SelectedItem == "Buying a property.")
            {
                //
                if (udDeposit.Value >= udPurchasePrice.Value)
                {
                    btnCalculate.Visible = false;
                    redDisplay.Visible = false;
                    MessageBox.Show("Deposit amount cannot be higher or equal to than the purchase price." +
                        "\nPlease enter valid amount.");
                

                }

                if (udInterest.Value > 100)
                {
                    btnCalculate.Visible = false;
                    redDisplay.Visible = false;
                    MessageBox.Show("Interest rate cannot be higher than 100." +
                        "\nPlease enter valid rate.");
                    udInterest.Value = 0;

                }

                if ((udRepayMonths.Value<240) || (udRepayMonths.Value>360))
                {
                    btnCalculate.Visible = false;
                    redDisplay.Visible = false;
                    MessageBox.Show("Invaldid number of months entered." +
                        "\nPlease input valid number of months - between 240 and 360.");
                }

            }




        }

        //Code in calculate and display button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Makes validation button invisible each time button is clicked
            btnComplete.Visible = false;

            //Clears the richTextBox everytime the button is clicked
            redDisplay.Clear();

            //Ceclare variables and assign input values to them
            //Converts input values to prefered datatype: double/real
            double grossIncome = decimal.ToDouble(udMonthlyIncome.Value);
            double groceries = decimal.ToDouble(udGroceries.Value);
            double water = decimal.ToDouble(udWaterLights.Value);
            double travel = decimal.ToDouble(udTravel.Value);
            double phone = decimal.ToDouble(udPhone.Value);
            double other = decimal.ToDouble(udOtherEx.Value);
            double tax = decimal.ToDouble(udTax.Value);
            double rent = decimal.ToDouble(udRentAmount.Value);
            double purchasePrice = decimal.ToDouble(udPurchasePrice.Value);
            double totaldeposit = decimal.ToDouble(udDeposit.Value);
            double interest = decimal.ToDouble(udInterest.Value);
            double repay = decimal.ToDouble(udRepayMonths.Value);
            double RepaymentValue = 0.00;
            double monthlyRepaymentValue = 0.00;
            double monthlyAvailableMoney = 0.00;

            //declaing and populating expense array - datatype double
            //populates array with 7 values- the variables used to hold expense values
            double[] arrExpenses = new double[7]
                {groceries, water,travel,phone,other,tax,totaldeposit};

            //Calculating sum of expense array
            int sum = 0;
            for (int i = 0; i < arrExpenses.Length; i++)
            {
                //converts final sum to integer datatype
                sum = Convert.ToInt32(arrExpenses[i]);
            }

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

            //calculate a third of this months income
            double third = grossIncome * (1.00/3.00);

            //alerts user that home loan may not be approved 
            if (monthlyRepaymentValue > third)
            {
                MessageBox.Show("Sorry, approval of the home loan looks unlikely.");
            }

            //Displays relevant values if rent option is chosen
            if (cmbChooseHousing.SelectedItem == "Renting.")
            {

                //Calculates the monthly available amount by subtracting the sum of the expenses from the gross income
                monthlyAvailableMoney = grossIncome - (sum);

                //Displays gross income, rent amount, total expenses, monthly available amount
                    redDisplay.Text = "Your monthly gross income is: R" + Convert.ToString(grossIncome) +
                    "\n\nYou have chosen to rent a living space. Your monthly rent will be: R" +
                  
                    Convert.ToString(rent) +
                    "\n\nYour total expenses for the month excluding the rent expense is: R" +
                           
                    Convert.ToString(sum) +
                    "\n\nYour total expenses for the month incuding the rent expense is: R" +
                           
                    Convert.ToString(sum + rent) +
                    "\n\nAvailable amount before deducting the rent expense is: R" +
                    
                    Convert.ToString(monthlyAvailableMoney) +
                    "\n\nAvailable amount after deducting the rent expense is: R" +
                    
                    Convert.ToString(monthlyAvailableMoney - rent);

            }
              else
            {
                 if (cmbChooseHousing.SelectedItem == "Buying a Property.")
                 {


                    //Displays income, total expenses, monthly available amount, monthly repayment amaount, monthly repayment amount deducted from monthly available amount
                        redDisplay.Text = "Your monthly gross income is: R" + Convert.ToString(grossIncome) +
                        "\n\nYou have chosen to buy a property. Your monthly home loan repayment amount is: R" +
                       
                        Convert.ToString(monthlyRepaymentValue) + " and is likely to be approved." +
                        "\n\nYour total expenses for the month excluding the home loan repayment is: R" +
                        
                        Convert.ToString(sum) +
                        "\n\nYour total expenses for the month including the home loan repayment is: R" +
                      
                        Convert.ToString(sum + monthlyRepaymentValue) +
                        "\n\nAvailable amount before deducting the home repayment is: R" +
                      
                        Convert.ToString(monthlyAvailableMoney) +
                        "\n\nAvailable amount after deducting the home repayment is: R" +
                       
                        Convert.ToString(monthlyAvailableMoney - monthlyRepaymentValue)
                        ;

                    

                }

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
            btnCalculate.Visible = false;
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

        private void udVisible()
        {
            btnCalculate.Visible = false;
            redDisplay.Visible = false;
            btnComplete.Visible = true;
        }

        private void udMonthlyIncome_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udGroceries_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udWaterLights_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udTravel_ValueChanged(object sender, EventArgs e)
        {
            udVisible();

        }

        private void udPhone_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udOtherEx_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udTax_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udPurchasePrice_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udRentAmount_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udDeposit_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udInterest_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
        }

        private void udRepayMonths_ValueChanged(object sender, EventArgs e)
        {
            udVisible();
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

