namespace FormApp1
{
    partial class Form1
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
            lblname = new Label();
            lblweight = new Label();
            lblheight = new Label();
            txtbName = new TextBox();
            txtboxWeight = new TextBox();
            txtboxHeight = new TextBox();
            gender = new Label();
            rbfemale = new RadioButton();
            rbMale = new RadioButton();
            lblActivityLvl = new Label();
            cbActivityLevel = new ComboBox();
            lblUnit = new Label();
            rbMetric = new RadioButton();
            rbImperial = new RadioButton();
            btnCalculate = new Button();
            lblBirthyear = new Label();
            txtbBirthYear = new TextBox();
            lblRecWaterIntake = new Label();
            lblMetricIntake = new Label();
            rstImperial = new Label();
            lblRestSavings = new Label();
            comboBox1 = new ComboBox();
            retAge = new Label();
            lblCurSav = new Label();
            lblMonthSav = new Label();
            lblAnnualInterest = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblYeartoRet = new Label();
            lblTotalFutureAmount = new Label();
            lblTotInterest = new Label();
            lblTotInvestment = new Label();
            lblGrowthInPer = new Label();
            rsltYearstoRetirement = new Label();
            RsltFutureAmount = new Label();
            RsltTotInterest = new Label();
            rstTotalInvestment = new Label();
            rstTotalGrowth = new Label();
            rbOther = new RadioButton();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = SystemColors.Control;
            lblname.Font = new Font("Bookman Old Style", 10F);
            lblname.Location = new Point(12, 32);
            lblname.Name = "lblname";
            lblname.Size = new Size(66, 23);
            lblname.TabIndex = 1;
            lblname.Text = "Name";
            // 
            // lblweight
            // 
            lblweight.AutoSize = true;
            lblweight.Font = new Font("Bookman Old Style", 10F);
            lblweight.Location = new Point(12, 83);
            lblweight.Name = "lblweight";
            lblweight.Size = new Size(119, 23);
            lblweight.TabIndex = 1;
            lblweight.Text = "Weight (kg)";
            // 
            // lblheight
            // 
            lblheight.AutoSize = true;
            lblheight.Font = new Font("Bookman Old Style", 10F);
            lblheight.Location = new Point(12, 135);
            lblheight.Name = "lblheight";
            lblheight.Size = new Size(115, 23);
            lblheight.TabIndex = 2;
            lblheight.Text = "Height(cm)";
            // 
            // txtbName
            // 
            txtbName.Font = new Font("Bookman Old Style", 10F);
            txtbName.Location = new Point(129, 29);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(195, 31);
            txtbName.TabIndex = 4;
            // 
            // txtboxWeight
            // 
            txtboxWeight.Font = new Font("Bookman Old Style", 10F);
            txtboxWeight.Location = new Point(128, 79);
            txtboxWeight.Name = "txtboxWeight";
            txtboxWeight.Size = new Size(196, 31);
            txtboxWeight.TabIndex = 4;
            // 
            // txtboxHeight
            // 
            txtboxHeight.Font = new Font("Bookman Old Style", 10F);
            txtboxHeight.Location = new Point(129, 132);
            txtboxHeight.Name = "txtboxHeight";
            txtboxHeight.Size = new Size(196, 31);
            txtboxHeight.TabIndex = 5;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Bookman Old Style", 10F);
            gender.Location = new Point(386, 29);
            gender.Name = "gender";
            gender.Size = new Size(82, 23);
            gender.TabIndex = 6;
            gender.Text = "Gender";
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Font = new Font("Bookman Old Style", 10F);
            rbfemale.Location = new Point(473, 29);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(106, 27);
            rbfemale.TabIndex = 7;
            rbfemale.TabStop = true;
            rbfemale.Text = "Female";
            rbfemale.UseVisualStyleBackColor = true;
            rbfemale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Bookman Old Style", 10F);
            rbMale.Location = new Point(589, 29);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(82, 27);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblActivityLvl
            // 
            lblActivityLvl.AutoSize = true;
            lblActivityLvl.Font = new Font("Bookman Old Style", 10F);
            lblActivityLvl.Location = new Point(386, 132);
            lblActivityLvl.Name = "lblActivityLvl";
            lblActivityLvl.Size = new Size(135, 23);
            lblActivityLvl.TabIndex = 9;
            lblActivityLvl.Text = "Activity level";
            // 
            // cbActivityLevel
            // 
            cbActivityLevel.Font = new Font("Bookman Old Style", 10F);
            cbActivityLevel.FormattingEnabled = true;
            cbActivityLevel.Location = new Point(527, 124);
            cbActivityLevel.Name = "cbActivityLevel";
            cbActivityLevel.Size = new Size(175, 31);
            cbActivityLevel.TabIndex = 10;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Bookman Old Style", 10F);
            lblUnit.Location = new Point(21, 217);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(53, 23);
            lblUnit.TabIndex = 11;
            lblUnit.Text = "Unit";
            lblUnit.Click += label1_Click;
            // 
            // rbMetric
            // 
            rbMetric.AutoSize = true;
            rbMetric.Font = new Font("Bookman Old Style", 10F);
            rbMetric.Location = new Point(108, 217);
            rbMetric.Name = "rbMetric";
            rbMetric.Size = new Size(97, 27);
            rbMetric.TabIndex = 12;
            rbMetric.TabStop = true;
            rbMetric.Text = "Metric";
            rbMetric.UseVisualStyleBackColor = true;
            rbMetric.CheckedChanged += rbMetric_CheckedChanged;
            // 
            // rbImperial
            // 
            rbImperial.AutoSize = true;
            rbImperial.Font = new Font("Bookman Old Style", 10F);
            rbImperial.Location = new Point(224, 217);
            rbImperial.Name = "rbImperial";
            rbImperial.Size = new Size(117, 27);
            rbImperial.TabIndex = 13;
            rbImperial.TabStop = true;
            rbImperial.Text = "Imperial";
            rbImperial.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Bookman Old Style", 10F);
            btnCalculate.Location = new Point(386, 254);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(305, 53);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate!";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // lblBirthyear
            // 
            lblBirthyear.AutoSize = true;
            lblBirthyear.Font = new Font("Bookman Old Style", 10F);
            lblBirthyear.Location = new Point(386, 187);
            lblBirthyear.Name = "lblBirthyear";
            lblBirthyear.Size = new Size(110, 23);
            lblBirthyear.TabIndex = 15;
            lblBirthyear.Text = "Birth year";
            // 
            // txtbBirthYear
            // 
            txtbBirthYear.Font = new Font("Bookman Old Style", 10F);
            txtbBirthYear.Location = new Point(527, 184);
            txtbBirthYear.Name = "txtbBirthYear";
            txtbBirthYear.Size = new Size(175, 31);
            txtbBirthYear.TabIndex = 16;
            // 
            // lblRecWaterIntake
            // 
            lblRecWaterIntake.AutoSize = true;
            lblRecWaterIntake.Font = new Font("Bookman Old Style", 10F);
            lblRecWaterIntake.Location = new Point(760, 29);
            lblRecWaterIntake.Name = "lblRecWaterIntake";
            lblRecWaterIntake.Size = new Size(324, 23);
            lblRecWaterIntake.TabIndex = 17;
            lblRecWaterIntake.Text = "Recomended dailty water intake";
            // 
            // lblMetricIntake
            // 
            lblMetricIntake.Font = new Font("Bookman Old Style", 10F);
            lblMetricIntake.Location = new Point(760, 87);
            lblMetricIntake.Name = "lblMetricIntake";
            lblMetricIntake.Size = new Size(263, 35);
            lblMetricIntake.TabIndex = 18;
            lblMetricIntake.Text = "label1";
            lblMetricIntake.TextAlign = ContentAlignment.TopCenter;
            // 
            // rstImperial
            // 
            rstImperial.Font = new Font("Bookman Old Style", 10F);
            rstImperial.Location = new Point(760, 138);
            rstImperial.Name = "rstImperial";
            rstImperial.Size = new Size(263, 35);
            rstImperial.TabIndex = 19;
            rstImperial.Text = "label2";
            rstImperial.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRestSavings
            // 
            lblRestSavings.AutoSize = true;
            lblRestSavings.Font = new Font("Bookman Old Style", 10F);
            lblRestSavings.Location = new Point(12, 350);
            lblRestSavings.Name = "lblRestSavings";
            lblRestSavings.Size = new Size(198, 23);
            lblRestSavings.TabIndex = 20;
            lblRestSavings.Text = "Retirement savings";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Bookman Old Style", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 389);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(81, 31);
            comboBox1.TabIndex = 21;
            // 
            // retAge
            // 
            retAge.AutoSize = true;
            retAge.Font = new Font("Bookman Old Style", 10F);
            retAge.Location = new Point(12, 392);
            retAge.Name = "retAge";
            retAge.Size = new Size(161, 23);
            retAge.TabIndex = 22;
            retAge.Text = "Retirement Age";
            retAge.Click += label1_Click_1;
            // 
            // lblCurSav
            // 
            lblCurSav.AutoSize = true;
            lblCurSav.Font = new Font("Bookman Old Style", 10F);
            lblCurSav.Location = new Point(270, 387);
            lblCurSav.Name = "lblCurSav";
            lblCurSav.Size = new Size(171, 23);
            lblCurSav.TabIndex = 23;
            lblCurSav.Text = "Current Savings";
            // 
            // lblMonthSav
            // 
            lblMonthSav.AutoSize = true;
            lblMonthSav.Font = new Font("Bookman Old Style", 10F);
            lblMonthSav.Location = new Point(270, 427);
            lblMonthSav.Name = "lblMonthSav";
            lblMonthSav.Size = new Size(172, 23);
            lblMonthSav.TabIndex = 24;
            lblMonthSav.Text = "Monthly Savings";
            // 
            // lblAnnualInterest
            // 
            lblAnnualInterest.AutoSize = true;
            lblAnnualInterest.Font = new Font("Bookman Old Style", 10F);
            lblAnnualInterest.Location = new Point(270, 468);
            lblAnnualInterest.Name = "lblAnnualInterest";
            lblAnnualInterest.Size = new Size(166, 23);
            lblAnnualInterest.TabIndex = 25;
            lblAnnualInterest.Text = "Annual Interest";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bookman Old Style", 10F);
            textBox2.Location = new Point(447, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 31);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bookman Old Style", 10F);
            textBox3.Location = new Point(446, 421);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Bookman Old Style", 10F);
            textBox4.Location = new Point(446, 460);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 31);
            textBox4.TabIndex = 28;
            // 
            // lblYeartoRet
            // 
            lblYeartoRet.AutoSize = true;
            lblYeartoRet.Font = new Font("Bookman Old Style", 10F);
            lblYeartoRet.Location = new Point(634, 384);
            lblYeartoRet.Name = "lblYeartoRet";
            lblYeartoRet.Size = new Size(205, 23);
            lblYeartoRet.TabIndex = 29;
            lblYeartoRet.Text = "Years to Retirement";
            // 
            // lblTotalFutureAmount
            // 
            lblTotalFutureAmount.AutoSize = true;
            lblTotalFutureAmount.Font = new Font("Bookman Old Style", 10F);
            lblTotalFutureAmount.Location = new Point(634, 420);
            lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            lblTotalFutureAmount.Size = new Size(218, 23);
            lblTotalFutureAmount.TabIndex = 30;
            lblTotalFutureAmount.Text = "Total Future Amount";
            // 
            // lblTotInterest
            // 
            lblTotInterest.AutoSize = true;
            lblTotInterest.Font = new Font("Bookman Old Style", 10F);
            lblTotInterest.Location = new Point(634, 465);
            lblTotInterest.Name = "lblTotInterest";
            lblTotInterest.Size = new Size(143, 23);
            lblTotInterest.TabIndex = 31;
            lblTotInterest.Text = "Total Interest";
            // 
            // lblTotInvestment
            // 
            lblTotInvestment.AutoSize = true;
            lblTotInvestment.Font = new Font("Bookman Old Style", 10F);
            lblTotInvestment.Location = new Point(634, 507);
            lblTotInvestment.Name = "lblTotInvestment";
            lblTotInvestment.Size = new Size(176, 23);
            lblTotInvestment.TabIndex = 32;
            lblTotInvestment.Text = "Total Investment";
            // 
            // lblGrowthInPer
            // 
            lblGrowthInPer.AutoSize = true;
            lblGrowthInPer.Font = new Font("Bookman Old Style", 10F);
            lblGrowthInPer.Location = new Point(634, 550);
            lblGrowthInPer.Name = "lblGrowthInPer";
            lblGrowthInPer.Size = new Size(190, 23);
            lblGrowthInPer.TabIndex = 33;
            lblGrowthInPer.Text = "Total Growth in %";
            // 
            // rsltYearstoRetirement
            // 
            rsltYearstoRetirement.Font = new Font("Bookman Old Style", 10F);
            rsltYearstoRetirement.Location = new Point(933, 382);
            rsltYearstoRetirement.Name = "rsltYearstoRetirement";
            rsltYearstoRetirement.Size = new Size(8, 8);
            rsltYearstoRetirement.TabIndex = 34;
            rsltYearstoRetirement.Text = "label1";
            // 
            // RsltFutureAmount
            // 
            RsltFutureAmount.Font = new Font("Bookman Old Style", 10F);
            RsltFutureAmount.Location = new Point(906, 422);
            RsltFutureAmount.Name = "RsltFutureAmount";
            RsltFutureAmount.Size = new Size(88, 38);
            RsltFutureAmount.TabIndex = 35;
            RsltFutureAmount.Text = "label2";
            // 
            // RsltTotInterest
            // 
            RsltTotInterest.Font = new Font("Bookman Old Style", 10F);
            RsltTotInterest.Location = new Point(906, 466);
            RsltTotInterest.Name = "RsltTotInterest";
            RsltTotInterest.Size = new Size(8, 8);
            RsltTotInterest.TabIndex = 36;
            RsltTotInterest.Text = "label3";
            // 
            // rstTotalInvestment
            // 
            rstTotalInvestment.Font = new Font("Bookman Old Style", 10F);
            rstTotalInvestment.Location = new Point(906, 515);
            rstTotalInvestment.Name = "rstTotalInvestment";
            rstTotalInvestment.Size = new Size(8, 8);
            rstTotalInvestment.TabIndex = 37;
            rstTotalInvestment.Text = "label4";
            // 
            // rstTotalGrowth
            // 
            rstTotalGrowth.Font = new Font("Bookman Old Style", 10F);
            rstTotalGrowth.Location = new Point(906, 550);
            rstTotalGrowth.Name = "rstTotalGrowth";
            rstTotalGrowth.Size = new Size(88, 38);
            rstTotalGrowth.TabIndex = 38;
            rstTotalGrowth.Text = "label5";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOther.Location = new Point(473, 62);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(148, 27);
            rbOther.TabIndex = 39;
            rbOther.TabStop = true;
            rbOther.Text = "Non-Binary";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 659);
            Controls.Add(rbOther);
            Controls.Add(rstTotalGrowth);
            Controls.Add(rstTotalInvestment);
            Controls.Add(RsltTotInterest);
            Controls.Add(RsltFutureAmount);
            Controls.Add(rsltYearstoRetirement);
            Controls.Add(lblGrowthInPer);
            Controls.Add(lblTotInvestment);
            Controls.Add(lblTotInterest);
            Controls.Add(lblTotalFutureAmount);
            Controls.Add(lblYeartoRet);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblAnnualInterest);
            Controls.Add(lblMonthSav);
            Controls.Add(lblCurSav);
            Controls.Add(retAge);
            Controls.Add(comboBox1);
            Controls.Add(lblRestSavings);
            Controls.Add(rstImperial);
            Controls.Add(lblMetricIntake);
            Controls.Add(lblRecWaterIntake);
            Controls.Add(txtbBirthYear);
            Controls.Add(lblBirthyear);
            Controls.Add(btnCalculate);
            Controls.Add(rbImperial);
            Controls.Add(rbMetric);
            Controls.Add(lblUnit);
            Controls.Add(cbActivityLevel);
            Controls.Add(lblActivityLvl);
            Controls.Add(rbMale);
            Controls.Add(rbfemale);
            Controls.Add(gender);
            Controls.Add(txtboxHeight);
            Controls.Add(txtboxWeight);
            Controls.Add(txtbName);
            Controls.Add(lblheight);
            Controls.Add(lblweight);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblweight;
        private Label lblheight;
        private TextBox txtbName;
        private TextBox txtboxWeight;
        private TextBox txtboxHeight;
        private Label gender;
        private RadioButton rbfemale;
        private RadioButton rbMale;
        private Label lblActivityLvl;
        private ComboBox cbActivityLevel;
        private Label lblUnit;
        private RadioButton rbMetric;
        private RadioButton rbImperial;
        private Button btnCalculate;
        private Label lblBirthyear;
        private TextBox txtbBirthYear;
        private Label lblRecWaterIntake;
        private Label lblMetricIntake;
        private Label rstImperial;
        private Label lblRestSavings;
        private ComboBox comboBox1;
        private Label retAge;
        private Label lblCurSav;
        private Label lblMonthSav;
        private Label lblAnnualInterest;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblYeartoRet;
        private Label lblTotalFutureAmount;
        private Label lblTotInterest;
        private Label lblTotInvestment;
        private Label lblGrowthInPer;
        private Label rsltYearstoRetirement;
        private Label RsltFutureAmount;
        private Label RsltTotInterest;
        private Label rstTotalInvestment;
        private Label rstTotalGrowth;
        private RadioButton rbOther;
    }
}
