
namespace PROG_POE_Part1_BudgetPlanner
{
    partial class frmBudgetPlanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudMonthlyIncome = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGroceries = new System.Windows.Forms.NumericUpDown();
            this.nudWaterLights = new System.Windows.Forms.NumericUpDown();
            this.nudTravel = new System.Windows.Forms.NumericUpDown();
            this.nudPhone = new System.Windows.Forms.NumericUpDown();
            this.nudOtherEx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbChooseHousing = new System.Windows.Forms.ComboBox();
            this.lblRentAmount = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.nudRentAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblRepay = new System.Windows.Forms.Label();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.nudDeposit = new System.Windows.Forms.NumericUpDown();
            this.nudInterest = new System.Windows.Forms.NumericUpDown();
            this.nudRepay = new System.Windows.Forms.NumericUpDown();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaterLights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Planner";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalculate.Location = new System.Drawing.Point(1525, 237);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(194, 48);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudMonthlyIncome
            // 
            this.nudMonthlyIncome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudMonthlyIncome.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudMonthlyIncome.Location = new System.Drawing.Point(390, 246);
            this.nudMonthlyIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMonthlyIncome.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMonthlyIncome.Name = "nudMonthlyIncome";
            this.nudMonthlyIncome.Size = new System.Drawing.Size(180, 35);
            this.nudMonthlyIncome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(87, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter gross monthly \r\nincome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(87, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the following monthly expenditure amounts:";
            // 
            // nudGroceries
            // 
            this.nudGroceries.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudGroceries.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudGroceries.Location = new System.Drawing.Point(390, 383);
            this.nudGroceries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGroceries.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGroceries.Name = "nudGroceries";
            this.nudGroceries.Size = new System.Drawing.Size(180, 35);
            this.nudGroceries.TabIndex = 5;
            // 
            // nudWaterLights
            // 
            this.nudWaterLights.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudWaterLights.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudWaterLights.Location = new System.Drawing.Point(390, 445);
            this.nudWaterLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudWaterLights.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWaterLights.Name = "nudWaterLights";
            this.nudWaterLights.Size = new System.Drawing.Size(180, 35);
            this.nudWaterLights.TabIndex = 6;
            // 
            // nudTravel
            // 
            this.nudTravel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudTravel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudTravel.Location = new System.Drawing.Point(390, 514);
            this.nudTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTravel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTravel.Name = "nudTravel";
            this.nudTravel.Size = new System.Drawing.Size(180, 35);
            this.nudTravel.TabIndex = 7;
            // 
            // nudPhone
            // 
            this.nudPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudPhone.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudPhone.Location = new System.Drawing.Point(390, 591);
            this.nudPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPhone.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPhone.Name = "nudPhone";
            this.nudPhone.Size = new System.Drawing.Size(180, 35);
            this.nudPhone.TabIndex = 8;
            // 
            // nudOtherEx
            // 
            this.nudOtherEx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudOtherEx.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudOtherEx.Location = new System.Drawing.Point(390, 656);
            this.nudOtherEx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOtherEx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOtherEx.Name = "nudOtherEx";
            this.nudOtherEx.Size = new System.Drawing.Size(180, 35);
            this.nudOtherEx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(87, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Groceries:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(87, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Water and lights:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(87, 504);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(174, 58);
            this.label6.TabIndex = 12;
            this.label6.Text = "Travel costs \r\n(petrol included):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(87, 581);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 58);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cellphone and \r\ntelephone costs:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(87, 658);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Other Expenses:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(718, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 58);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter estimated monthly\r\ntax deducted: ";
            // 
            // nudTax
            // 
            this.nudTax.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudTax.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudTax.Location = new System.Drawing.Point(975, 246);
            this.nudTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(180, 35);
            this.nudTax.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(718, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Choose Between: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbChooseHousing
            // 
            this.cmbChooseHousing.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbChooseHousing.FormattingEnabled = true;
            this.cmbChooseHousing.Items.AddRange(new object[] {
            "Renting.",
            "Buying a property."});
            this.cmbChooseHousing.Location = new System.Drawing.Point(975, 315);
            this.cmbChooseHousing.Name = "cmbChooseHousing";
            this.cmbChooseHousing.Size = new System.Drawing.Size(301, 37);
            this.cmbChooseHousing.TabIndex = 18;
            this.cmbChooseHousing.SelectedIndexChanged += new System.EventHandler(this.cmbChooseHousing_SelectedIndexChanged);
            // 
            // lblRentAmount
            // 
            this.lblRentAmount.AutoSize = true;
            this.lblRentAmount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentAmount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRentAmount.Location = new System.Drawing.Point(718, 435);
            this.lblRentAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentAmount.Name = "lblRentAmount";
            this.lblRentAmount.Size = new System.Drawing.Size(150, 58);
            this.lblRentAmount.TabIndex = 19;
            this.lblRentAmount.Text = "Rental amount\r\n(monthly):";
            this.lblRentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRentAmount.Visible = false;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEnter.Location = new System.Drawing.Point(718, 385);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(71, 29);
            this.lblEnter.TabIndex = 20;
            this.lblEnter.Text = "Enter:";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnter.Visible = false;
            // 
            // nudRentAmount
            // 
            this.nudRentAmount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudRentAmount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudRentAmount.Location = new System.Drawing.Point(975, 445);
            this.nudRentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRentAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRentAmount.Name = "nudRentAmount";
            this.nudRentAmount.Size = new System.Drawing.Size(180, 35);
            this.nudRentAmount.TabIndex = 21;
            this.nudRentAmount.Visible = false;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPurchasePrice.Location = new System.Drawing.Point(718, 447);
            this.lblPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(162, 29);
            this.lblPurchasePrice.TabIndex = 22;
            this.lblPurchasePrice.Text = "Purchase Price:";
            this.lblPurchasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPurchasePrice.Visible = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDeposit.Location = new System.Drawing.Point(718, 516);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(149, 29);
            this.lblDeposit.TabIndex = 23;
            this.lblDeposit.Text = "Total Deposit: ";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeposit.Visible = false;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterest.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInterest.Location = new System.Drawing.Point(718, 581);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(140, 58);
            this.lblInterest.TabIndex = 24;
            this.lblInterest.Text = "Interest rate\r\n(percentage):";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInterest.Visible = false;
            // 
            // lblRepay
            // 
            this.lblRepay.AutoSize = true;
            this.lblRepay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRepay.Location = new System.Drawing.Point(718, 658);
            this.lblRepay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepay.Name = "lblRepay";
            this.lblRepay.Size = new System.Drawing.Size(194, 87);
            this.lblRepay.TabIndex = 25;
            this.lblRepay.Text = "Number of months \r\nto repay (between\r\n240 and 360):";
            this.lblRepay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRepay.Visible = false;
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudPurchasePrice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudPurchasePrice.Location = new System.Drawing.Point(975, 447);
            this.nudPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPurchasePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(180, 35);
            this.nudPurchasePrice.TabIndex = 26;
            this.nudPurchasePrice.Visible = false;
            // 
            // nudDeposit
            // 
            this.nudDeposit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudDeposit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudDeposit.Location = new System.Drawing.Point(975, 514);
            this.nudDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDeposit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDeposit.Name = "nudDeposit";
            this.nudDeposit.Size = new System.Drawing.Size(180, 35);
            this.nudDeposit.TabIndex = 27;
            this.nudDeposit.Visible = false;
            // 
            // nudInterest
            // 
            this.nudInterest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudInterest.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudInterest.Location = new System.Drawing.Point(975, 591);
            this.nudInterest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudInterest.Name = "nudInterest";
            this.nudInterest.Size = new System.Drawing.Size(180, 35);
            this.nudInterest.TabIndex = 28;
            this.nudInterest.Visible = false;
            // 
            // nudRepay
            // 
            this.nudRepay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudRepay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nudRepay.Location = new System.Drawing.Point(975, 668);
            this.nudRepay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRepay.Name = "nudRepay";
            this.nudRepay.Size = new System.Drawing.Size(180, 35);
            this.nudRepay.TabIndex = 29;
            this.nudRepay.Visible = false;
            // 
            // redDisplay
            // 
            this.redDisplay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redDisplay.ForeColor = System.Drawing.Color.IndianRed;
            this.redDisplay.Location = new System.Drawing.Point(1398, 315);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(431, 634);
            this.redDisplay.TabIndex = 30;
            this.redDisplay.Text = "";
            // 
            // frmBudgetPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1924, 987);
            this.Controls.Add(this.redDisplay);
            this.Controls.Add(this.nudRepay);
            this.Controls.Add(this.nudInterest);
            this.Controls.Add(this.nudDeposit);
            this.Controls.Add(this.nudPurchasePrice);
            this.Controls.Add(this.lblRepay);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.nudRentAmount);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblRentAmount);
            this.Controls.Add(this.cmbChooseHousing);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudOtherEx);
            this.Controls.Add(this.nudPhone);
            this.Controls.Add(this.nudTravel);
            this.Controls.Add(this.nudWaterLights);
            this.Controls.Add(this.nudGroceries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMonthlyIncome);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBudgetPlanner";
            this.Text = "Budget Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaterLights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudMonthlyIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudGroceries;
        private System.Windows.Forms.NumericUpDown nudWaterLights;
        private System.Windows.Forms.NumericUpDown nudTravel;
        private System.Windows.Forms.NumericUpDown nudPhone;
        private System.Windows.Forms.NumericUpDown nudOtherEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbChooseHousing;
        private System.Windows.Forms.Label lblRentAmount;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.NumericUpDown nudRentAmount;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblRepay;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.NumericUpDown nudDeposit;
        private System.Windows.Forms.NumericUpDown nudInterest;
        private System.Windows.Forms.NumericUpDown nudRepay;
        private System.Windows.Forms.RichTextBox redDisplay;
    }
}

