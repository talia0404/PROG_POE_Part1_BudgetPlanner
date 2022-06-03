
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbChooseHousing = new System.Windows.Forms.ComboBox();
            this.lblRentAmount = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblRepay = new System.Windows.Forms.Label();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            this.udMonthlyIncome = new System.Windows.Forms.NumericUpDown();
            this.udGroceries = new System.Windows.Forms.NumericUpDown();
            this.udWaterLights = new System.Windows.Forms.NumericUpDown();
            this.udTravel = new System.Windows.Forms.NumericUpDown();
            this.udPhone = new System.Windows.Forms.NumericUpDown();
            this.udOtherEx = new System.Windows.Forms.NumericUpDown();
            this.udTax = new System.Windows.Forms.NumericUpDown();
            this.udPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.udRentAmount = new System.Windows.Forms.NumericUpDown();
            this.udDeposit = new System.Windows.Forms.NumericUpDown();
            this.udInterest = new System.Windows.Forms.NumericUpDown();
            this.udRepayMonths = new System.Windows.Forms.NumericUpDown();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnClearExpenses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearRent = new System.Windows.Forms.Button();
            this.btnClearHomeLoan = new System.Windows.Forms.Button();
            this.cmbVehicleChoice = new System.Windows.Forms.ComboBox();
            this.lblVehicleChoice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udMonthlyIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWaterLights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOtherEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRepayMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.btnCalculate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(1525, 237);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(194, 48);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(87, 181);
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
            this.label3.Location = new System.Drawing.Point(87, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the following monthly expenditure amounts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(87, 329);
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
            this.label5.Location = new System.Drawing.Point(87, 391);
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
            this.label6.Location = new System.Drawing.Point(87, 448);
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
            this.label7.Location = new System.Drawing.Point(87, 525);
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
            this.label8.Location = new System.Drawing.Point(87, 602);
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
            this.label9.Location = new System.Drawing.Point(718, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 58);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter estimated monthly\r\ntax deducted: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(718, 262);
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
            this.cmbChooseHousing.Location = new System.Drawing.Point(975, 259);
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
            this.lblRentAmount.Location = new System.Drawing.Point(718, 379);
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
            this.lblEnter.Location = new System.Drawing.Point(718, 329);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(71, 29);
            this.lblEnter.TabIndex = 20;
            this.lblEnter.Text = "Enter:";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnter.Visible = false;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPurchasePrice.Location = new System.Drawing.Point(718, 391);
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
            this.lblDeposit.Location = new System.Drawing.Point(718, 460);
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
            this.lblInterest.Location = new System.Drawing.Point(718, 525);
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
            this.lblRepay.Location = new System.Drawing.Point(718, 602);
            this.lblRepay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepay.Name = "lblRepay";
            this.lblRepay.Size = new System.Drawing.Size(194, 87);
            this.lblRepay.TabIndex = 25;
            this.lblRepay.Text = "Number of months \r\nto repay (between\r\n240 and 360):";
            this.lblRepay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRepay.Visible = false;
            // 
            // redDisplay
            // 
            this.redDisplay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redDisplay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.redDisplay.Location = new System.Drawing.Point(1398, 315);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(431, 608);
            this.redDisplay.TabIndex = 30;
            this.redDisplay.Text = "";
            this.redDisplay.Visible = false;
            // 
            // udMonthlyIncome
            // 
            this.udMonthlyIncome.DecimalPlaces = 2;
            this.udMonthlyIncome.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udMonthlyIncome.Location = new System.Drawing.Point(390, 183);
            this.udMonthlyIncome.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.udMonthlyIncome.Name = "udMonthlyIncome";
            this.udMonthlyIncome.Size = new System.Drawing.Size(180, 30);
            this.udMonthlyIncome.TabIndex = 44;
            this.udMonthlyIncome.ValueChanged += new System.EventHandler(this.udMonthlyIncome_ValueChanged);
            // 
            // udGroceries
            // 
            this.udGroceries.DecimalPlaces = 2;
            this.udGroceries.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udGroceries.Location = new System.Drawing.Point(390, 331);
            this.udGroceries.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.udGroceries.Name = "udGroceries";
            this.udGroceries.Size = new System.Drawing.Size(180, 30);
            this.udGroceries.TabIndex = 45;
            this.udGroceries.ValueChanged += new System.EventHandler(this.udGroceries_ValueChanged);
            // 
            // udWaterLights
            // 
            this.udWaterLights.DecimalPlaces = 2;
            this.udWaterLights.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udWaterLights.Location = new System.Drawing.Point(390, 391);
            this.udWaterLights.Maximum = new decimal(new int[] {
            -1063649280,
            1831510949,
            5,
            0});
            this.udWaterLights.Name = "udWaterLights";
            this.udWaterLights.Size = new System.Drawing.Size(180, 30);
            this.udWaterLights.TabIndex = 46;
            this.udWaterLights.ValueChanged += new System.EventHandler(this.udWaterLights_ValueChanged);
            // 
            // udTravel
            // 
            this.udTravel.DecimalPlaces = 2;
            this.udTravel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udTravel.Location = new System.Drawing.Point(390, 465);
            this.udTravel.Maximum = new decimal(new int[] {
            -1063649280,
            1831510949,
            5,
            0});
            this.udTravel.Name = "udTravel";
            this.udTravel.Size = new System.Drawing.Size(180, 30);
            this.udTravel.TabIndex = 47;
            this.udTravel.ValueChanged += new System.EventHandler(this.udTravel_ValueChanged);
            // 
            // udPhone
            // 
            this.udPhone.DecimalPlaces = 2;
            this.udPhone.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPhone.Location = new System.Drawing.Point(390, 542);
            this.udPhone.Maximum = new decimal(new int[] {
            -1063649280,
            1831510949,
            5,
            0});
            this.udPhone.Name = "udPhone";
            this.udPhone.Size = new System.Drawing.Size(180, 30);
            this.udPhone.TabIndex = 48;
            this.udPhone.ValueChanged += new System.EventHandler(this.udPhone_ValueChanged);
            // 
            // udOtherEx
            // 
            this.udOtherEx.DecimalPlaces = 2;
            this.udOtherEx.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udOtherEx.Location = new System.Drawing.Point(390, 604);
            this.udOtherEx.Name = "udOtherEx";
            this.udOtherEx.Size = new System.Drawing.Size(180, 30);
            this.udOtherEx.TabIndex = 49;
            this.udOtherEx.ValueChanged += new System.EventHandler(this.udOtherEx_ValueChanged);
            // 
            // udTax
            // 
            this.udTax.DecimalPlaces = 2;
            this.udTax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udTax.Location = new System.Drawing.Point(1056, 191);
            this.udTax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.udTax.Name = "udTax";
            this.udTax.Size = new System.Drawing.Size(180, 30);
            this.udTax.TabIndex = 50;
            this.udTax.ValueChanged += new System.EventHandler(this.udTax_ValueChanged);
            // 
            // udPurchasePrice
            // 
            this.udPurchasePrice.DecimalPlaces = 2;
            this.udPurchasePrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPurchasePrice.Location = new System.Drawing.Point(1056, 390);
            this.udPurchasePrice.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.udPurchasePrice.Name = "udPurchasePrice";
            this.udPurchasePrice.Size = new System.Drawing.Size(180, 30);
            this.udPurchasePrice.TabIndex = 51;
            this.udPurchasePrice.Visible = false;
            this.udPurchasePrice.ValueChanged += new System.EventHandler(this.udPurchasePrice_ValueChanged);
            // 
            // udRentAmount
            // 
            this.udRentAmount.DecimalPlaces = 2;
            this.udRentAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRentAmount.Location = new System.Drawing.Point(1056, 396);
            this.udRentAmount.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.udRentAmount.Name = "udRentAmount";
            this.udRentAmount.Size = new System.Drawing.Size(180, 30);
            this.udRentAmount.TabIndex = 52;
            this.udRentAmount.Visible = false;
            this.udRentAmount.ValueChanged += new System.EventHandler(this.udRentAmount_ValueChanged);
            // 
            // udDeposit
            // 
            this.udDeposit.DecimalPlaces = 2;
            this.udDeposit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udDeposit.Location = new System.Drawing.Point(1056, 462);
            this.udDeposit.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.udDeposit.Name = "udDeposit";
            this.udDeposit.Size = new System.Drawing.Size(180, 30);
            this.udDeposit.TabIndex = 53;
            this.udDeposit.Visible = false;
            this.udDeposit.ValueChanged += new System.EventHandler(this.udDeposit_ValueChanged);
            // 
            // udInterest
            // 
            this.udInterest.DecimalPlaces = 2;
            this.udInterest.Location = new System.Drawing.Point(1056, 542);
            this.udInterest.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.udInterest.Name = "udInterest";
            this.udInterest.Size = new System.Drawing.Size(180, 30);
            this.udInterest.TabIndex = 54;
            this.udInterest.Visible = false;
            this.udInterest.ValueChanged += new System.EventHandler(this.udInterest_ValueChanged);
            // 
            // udRepayMonths
            // 
            this.udRepayMonths.DecimalPlaces = 2;
            this.udRepayMonths.Location = new System.Drawing.Point(1056, 633);
            this.udRepayMonths.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.udRepayMonths.Name = "udRepayMonths";
            this.udRepayMonths.Size = new System.Drawing.Size(180, 30);
            this.udRepayMonths.TabIndex = 55;
            this.udRepayMonths.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.udRepayMonths.Visible = false;
            this.udRepayMonths.ValueChanged += new System.EventHandler(this.udRepayMonths_ValueChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnComplete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(1143, 875);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(194, 48);
            this.btnComplete.TabIndex = 56;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnClearExpenses
            // 
            this.btnClearExpenses.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearExpenses.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearExpenses.ForeColor = System.Drawing.Color.White;
            this.btnClearExpenses.Location = new System.Drawing.Point(403, 653);
            this.btnClearExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearExpenses.Name = "btnClearExpenses";
            this.btnClearExpenses.Size = new System.Drawing.Size(157, 36);
            this.btnClearExpenses.TabIndex = 57;
            this.btnClearExpenses.Text = "CLEAR EXPENSE AMOUNTS";
            this.btnClearExpenses.UseVisualStyleBackColor = false;
            this.btnClearExpenses.Click += new System.EventHandler(this.btnClearExpenses_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1733, 928);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 48);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "RESTART";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearRent
            // 
            this.btnClearRent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearRent.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearRent.ForeColor = System.Drawing.Color.White;
            this.btnClearRent.Location = new System.Drawing.Point(1056, 698);
            this.btnClearRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearRent.Name = "btnClearRent";
            this.btnClearRent.Size = new System.Drawing.Size(187, 42);
            this.btnClearRent.TabIndex = 59;
            this.btnClearRent.Text = "CLEAR RENT AMOUNTS";
            this.btnClearRent.UseVisualStyleBackColor = false;
            this.btnClearRent.Visible = false;
            this.btnClearRent.Click += new System.EventHandler(this.btnClearRent_Click);
            // 
            // btnClearHomeLoan
            // 
            this.btnClearHomeLoan.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearHomeLoan.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearHomeLoan.ForeColor = System.Drawing.Color.White;
            this.btnClearHomeLoan.Location = new System.Drawing.Point(1056, 700);
            this.btnClearHomeLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearHomeLoan.Name = "btnClearHomeLoan";
            this.btnClearHomeLoan.Size = new System.Drawing.Size(184, 39);
            this.btnClearHomeLoan.TabIndex = 60;
            this.btnClearHomeLoan.Text = "CLEAR PROPERTY AMOUNTS";
            this.btnClearHomeLoan.UseVisualStyleBackColor = false;
            this.btnClearHomeLoan.Visible = false;
            this.btnClearHomeLoan.Click += new System.EventHandler(this.btnClearHomeLoan_Click);
            // 
            // cmbVehicleChoice
            // 
            this.cmbVehicleChoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbVehicleChoice.FormattingEnabled = true;
            this.cmbVehicleChoice.Items.AddRange(new object[] {
            "Yes.",
            "No."});
            this.cmbVehicleChoice.Location = new System.Drawing.Point(390, 720);
            this.cmbVehicleChoice.Name = "cmbVehicleChoice";
            this.cmbVehicleChoice.Size = new System.Drawing.Size(180, 37);
            this.cmbVehicleChoice.TabIndex = 62;
            // 
            // lblVehicleChoice
            // 
            this.lblVehicleChoice.AutoSize = true;
            this.lblVehicleChoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleChoice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblVehicleChoice.Location = new System.Drawing.Point(87, 723);
            this.lblVehicleChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleChoice.Name = "lblVehicleChoice";
            this.lblVehicleChoice.Size = new System.Drawing.Size(149, 29);
            this.lblVehicleChoice.TabIndex = 61;
            this.lblVehicleChoice.Text = "Buy a vehicle?";
            this.lblVehicleChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label11.Location = new System.Drawing.Point(87, 780);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 29);
            this.label11.TabIndex = 63;
            this.label11.Text = "Enter:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(278, 909);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(198, 30);
            this.numericUpDown1.TabIndex = 65;
            this.numericUpDown1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(87, 814);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 29);
            this.label12.TabIndex = 64;
            this.label12.Text = "Model:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 813);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 861);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 30);
            this.textBox2.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label13.Location = new System.Drawing.Point(87, 860);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 29);
            this.label13.TabIndex = 67;
            this.label13.Text = "Make:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label14.Location = new System.Drawing.Point(89, 907);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 29);
            this.label14.TabIndex = 69;
            this.label14.Text = "Purchase price:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label15.Location = new System.Drawing.Point(530, 812);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 29);
            this.label15.TabIndex = 71;
            this.label15.Text = "Purchase price:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(719, 814);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(198, 30);
            this.numericUpDown2.TabIndex = 70;
            this.numericUpDown2.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label16.Location = new System.Drawing.Point(530, 862);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 29);
            this.label16.TabIndex = 73;
            this.label16.Text = "Purchase price:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(718, 861);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(198, 30);
            this.numericUpDown3.TabIndex = 72;
            this.numericUpDown3.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label17.Location = new System.Drawing.Point(530, 907);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 29);
            this.label17.TabIndex = 75;
            this.label17.Text = "Purchase price:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Visible = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(719, 909);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(198, 30);
            this.numericUpDown4.TabIndex = 74;
            this.numericUpDown4.Visible = false;
            // 
            // frmBudgetPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1924, 987);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbVehicleChoice);
            this.Controls.Add(this.lblVehicleChoice);
            this.Controls.Add(this.btnClearHomeLoan);
            this.Controls.Add(this.btnClearRent);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearExpenses);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.udRepayMonths);
            this.Controls.Add(this.udInterest);
            this.Controls.Add(this.udDeposit);
            this.Controls.Add(this.udRentAmount);
            this.Controls.Add(this.udPurchasePrice);
            this.Controls.Add(this.udTax);
            this.Controls.Add(this.udOtherEx);
            this.Controls.Add(this.udPhone);
            this.Controls.Add(this.udTravel);
            this.Controls.Add(this.udWaterLights);
            this.Controls.Add(this.udGroceries);
            this.Controls.Add(this.udMonthlyIncome);
            this.Controls.Add(this.redDisplay);
            this.Controls.Add(this.lblRepay);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblRentAmount);
            this.Controls.Add(this.cmbChooseHousing);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBudgetPlanner";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.udMonthlyIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWaterLights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOtherEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRepayMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbChooseHousing;
        private System.Windows.Forms.Label lblRentAmount;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblRepay;
        private System.Windows.Forms.RichTextBox redDisplay;
        private System.Windows.Forms.NumericUpDown udMonthlyIncome;
        private System.Windows.Forms.NumericUpDown udGroceries;
        private System.Windows.Forms.NumericUpDown udWaterLights;
        private System.Windows.Forms.NumericUpDown udTravel;
        private System.Windows.Forms.NumericUpDown udPhone;
        private System.Windows.Forms.NumericUpDown udOtherEx;
        private System.Windows.Forms.NumericUpDown udTax;
        private System.Windows.Forms.NumericUpDown udPurchasePrice;
        private System.Windows.Forms.NumericUpDown udRentAmount;
        private System.Windows.Forms.NumericUpDown udDeposit;
        private System.Windows.Forms.NumericUpDown udInterest;
        private System.Windows.Forms.NumericUpDown udRepayMonths;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnClearExpenses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearRent;
        private System.Windows.Forms.Button btnClearHomeLoan;
        private System.Windows.Forms.ComboBox cmbVehicleChoice;
        private System.Windows.Forms.Label lblVehicleChoice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

