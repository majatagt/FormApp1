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
            rbfemale = new RadioButton();
            rbMale = new RadioButton();
            lblActivityLvl = new Label();
            cbActivityLevel = new ComboBox();
            rbMetric = new RadioButton();
            rbImperial = new RadioButton();
            btnCalculate = new Button();
            lblBirthyear = new Label();
            txtbBirthYear = new TextBox();
            lblRecWaterIntake = new Label();
            lblMetricIntake = new Label();
            lblRestSavings = new Label();
            retAge = new Label();
            lblCurSav = new Label();
            lblMonthSav = new Label();
            lblAnnualInterest = new Label();
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
            grbGender = new GroupBox();
            grbUnit = new GroupBox();
            grbGender.SuspendLayout();
            grbUnit.SuspendLayout();
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
            lblweight.TabIndex = 2;
            lblweight.Text = "Weight (kg)";
            lblweight.Click += lblweight_Click;
            // 
            // lblheight
            // 
            lblheight.AutoSize = true;
            lblheight.Font = new Font("Bookman Old Style", 10F);
            lblheight.Location = new Point(12, 135);
            lblheight.Name = "lblheight";
            lblheight.Size = new Size(115, 23);
            lblheight.TabIndex = 3;
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
            txtboxWeight.TabIndex = 5;
            txtboxWeight.TextChanged += txtboxWeight_TextChanged;
            // 
            // txtboxHeight
            // 
            txtboxHeight.Font = new Font("Bookman Old Style", 10F);
            txtboxHeight.Location = new Point(129, 132);
            txtboxHeight.Name = "txtboxHeight";
            txtboxHeight.Size = new Size(196, 31);
            txtboxHeight.TabIndex = 6;
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Font = new Font("Bookman Old Style", 10F);
            rbfemale.Location = new Point(94, 18);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(106, 27);
            rbfemale.TabIndex = 7;
            rbfemale.TabStop = true;
            rbfemale.Text = "Female";
            rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Bookman Old Style", 10F);
            rbMale.Location = new Point(210, 18);
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
            // rbMetric
            // 
            rbMetric.AutoSize = true;
            rbMetric.Font = new Font("Bookman Old Style", 10F);
            rbMetric.Location = new Point(18, 21);
            rbMetric.Name = "rbMetric";
            rbMetric.Size = new Size(97, 27);
            rbMetric.TabIndex = 11;
            rbMetric.TabStop = true;
            rbMetric.Text = "Metric";
            rbMetric.UseVisualStyleBackColor = true;
            rbMetric.CheckedChanged += rbMetric_CheckedChanged;
            // 
            // rbImperial
            // 
            rbImperial.AutoSize = true;
            rbImperial.Font = new Font("Bookman Old Style", 10F);
            rbImperial.Location = new Point(128, 21);
            rbImperial.Name = "rbImperial";
            rbImperial.Size = new Size(117, 27);
            rbImperial.TabIndex = 12;
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
            btnCalculate.TabIndex = 13;
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
            lblBirthyear.TabIndex = 14;
            lblBirthyear.Text = "Birth year";
            // 
            // txtbBirthYear
            // 
            txtbBirthYear.Font = new Font("Bookman Old Style", 10F);
            txtbBirthYear.Location = new Point(527, 184);
            txtbBirthYear.Name = "txtbBirthYear";
            txtbBirthYear.Size = new Size(175, 31);
            txtbBirthYear.TabIndex = 12;
            // 
            // lblRecWaterIntake
            // 
            lblRecWaterIntake.AutoSize = true;
            lblRecWaterIntake.Font = new Font("Bookman Old Style", 10F);
            lblRecWaterIntake.Location = new Point(729, 29);
            lblRecWaterIntake.Name = "lblRecWaterIntake";
            lblRecWaterIntake.Size = new Size(324, 23);
            lblRecWaterIntake.TabIndex = 16;
            lblRecWaterIntake.Text = "Recomended dailty water intake";
            // 
            // lblMetricIntake
            // 
            lblMetricIntake.AutoSize = true;
            lblMetricIntake.Font = new Font("Bookman Old Style", 10F);
            lblMetricIntake.Location = new Point(760, 87);
            lblMetricIntake.Name = "lblMetricIntake";
            lblMetricIntake.Size = new Size(68, 28);
            lblMetricIntake.TabIndex = 17;
            lblMetricIntake.Text = "label1";
            lblMetricIntake.TextAlign = ContentAlignment.TopCenter;
            lblMetricIntake.UseCompatibleTextRendering = true;
            lblMetricIntake.Click += lblMetricIntake_Click;
            // 
            // lblRestSavings
            // 
            lblRestSavings.Location = new Point(0, 0);
            lblRestSavings.Name = "lblRestSavings";
            lblRestSavings.Size = new Size(100, 23);
            lblRestSavings.TabIndex = 54;
            // 
            // retAge
            // 
            retAge.Location = new Point(0, 0);
            retAge.Name = "retAge";
            retAge.Size = new Size(100, 23);
            retAge.TabIndex = 53;
            // 
            // lblCurSav
            // 
            lblCurSav.Location = new Point(0, 0);
            lblCurSav.Name = "lblCurSav";
            lblCurSav.Size = new Size(100, 23);
            lblCurSav.TabIndex = 52;
            // 
            // lblMonthSav
            // 
            lblMonthSav.Location = new Point(0, 0);
            lblMonthSav.Name = "lblMonthSav";
            lblMonthSav.Size = new Size(100, 23);
            lblMonthSav.TabIndex = 51;
            // 
            // lblAnnualInterest
            // 
            lblAnnualInterest.Location = new Point(0, 0);
            lblAnnualInterest.Name = "lblAnnualInterest";
            lblAnnualInterest.Size = new Size(100, 23);
            lblAnnualInterest.TabIndex = 50;
            // 
            // lblYeartoRet
            // 
            lblYeartoRet.Location = new Point(0, 0);
            lblYeartoRet.Name = "lblYeartoRet";
            lblYeartoRet.Size = new Size(100, 23);
            lblYeartoRet.TabIndex = 49;
            // 
            // lblTotalFutureAmount
            // 
            lblTotalFutureAmount.Location = new Point(0, 0);
            lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            lblTotalFutureAmount.Size = new Size(100, 23);
            lblTotalFutureAmount.TabIndex = 48;
            // 
            // lblTotInterest
            // 
            lblTotInterest.Location = new Point(0, 0);
            lblTotInterest.Name = "lblTotInterest";
            lblTotInterest.Size = new Size(100, 23);
            lblTotInterest.TabIndex = 47;
            // 
            // lblTotInvestment
            // 
            lblTotInvestment.Location = new Point(0, 0);
            lblTotInvestment.Name = "lblTotInvestment";
            lblTotInvestment.Size = new Size(100, 23);
            lblTotInvestment.TabIndex = 46;
            // 
            // lblGrowthInPer
            // 
            lblGrowthInPer.Location = new Point(0, 0);
            lblGrowthInPer.Name = "lblGrowthInPer";
            lblGrowthInPer.Size = new Size(100, 23);
            lblGrowthInPer.TabIndex = 45;
            // 
            // rsltYearstoRetirement
            // 
            rsltYearstoRetirement.Location = new Point(0, 0);
            rsltYearstoRetirement.Name = "rsltYearstoRetirement";
            rsltYearstoRetirement.Size = new Size(100, 23);
            rsltYearstoRetirement.TabIndex = 44;
            // 
            // RsltFutureAmount
            // 
            RsltFutureAmount.Location = new Point(0, 0);
            RsltFutureAmount.Name = "RsltFutureAmount";
            RsltFutureAmount.Size = new Size(100, 23);
            RsltFutureAmount.TabIndex = 43;
            // 
            // RsltTotInterest
            // 
            RsltTotInterest.Location = new Point(0, 0);
            RsltTotInterest.Name = "RsltTotInterest";
            RsltTotInterest.Size = new Size(100, 23);
            RsltTotInterest.TabIndex = 42;
            // 
            // rstTotalInvestment
            // 
            rstTotalInvestment.Location = new Point(0, 0);
            rstTotalInvestment.Name = "rstTotalInvestment";
            rstTotalInvestment.Size = new Size(100, 23);
            rstTotalInvestment.TabIndex = 41;
            // 
            // rstTotalGrowth
            // 
            rstTotalGrowth.Location = new Point(0, 0);
            rstTotalGrowth.Name = "rstTotalGrowth";
            rstTotalGrowth.Size = new Size(100, 23);
            rstTotalGrowth.TabIndex = 40;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOther.Location = new Point(94, 51);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(148, 27);
            rbOther.TabIndex = 37;
            rbOther.TabStop = true;
            rbOther.Text = "Non-Binary";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // grbGender
            // 
            grbGender.Controls.Add(rbOther);
            grbGender.Controls.Add(rbMale);
            grbGender.Controls.Add(rbfemale);
            grbGender.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbGender.Location = new Point(379, 11);
            grbGender.Name = "grbGender";
            grbGender.Size = new Size(315, 89);
            grbGender.TabIndex = 38;
            grbGender.TabStop = false;
            grbGender.Text = "Gender";
            // 
            // grbUnit
            // 
            grbUnit.Controls.Add(rbImperial);
            grbUnit.Controls.Add(rbMetric);
            grbUnit.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbUnit.Location = new Point(12, 197);
            grbUnit.Name = "grbUnit";
            grbUnit.Size = new Size(277, 61);
            grbUnit.TabIndex = 39;
            grbUnit.TabStop = false;
            grbUnit.Text = "Unit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 659);
            Controls.Add(grbUnit);
            Controls.Add(grbGender);
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
            Controls.Add(lblAnnualInterest);
            Controls.Add(lblMonthSav);
            Controls.Add(lblCurSav);
            Controls.Add(retAge);
            Controls.Add(lblRestSavings);
            Controls.Add(lblMetricIntake);
            Controls.Add(lblRecWaterIntake);
            Controls.Add(txtbBirthYear);
            Controls.Add(lblBirthyear);
            Controls.Add(btnCalculate);
            Controls.Add(cbActivityLevel);
            Controls.Add(lblActivityLvl);
            Controls.Add(txtboxHeight);
            Controls.Add(txtboxWeight);
            Controls.Add(txtbName);
            Controls.Add(lblheight);
            Controls.Add(lblweight);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            grbGender.ResumeLayout(false);
            grbGender.PerformLayout();
            grbUnit.ResumeLayout(false);
            grbUnit.PerformLayout();
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
        private RadioButton rbfemale;
        private RadioButton rbMale;
        private Label lblActivityLvl;
        private ComboBox cbActivityLevel;
        private RadioButton rbMetric;
        private RadioButton rbImperial;
        private Button btnCalculate;
        private Label lblBirthyear;
        private TextBox txtbBirthYear;
        private Label lblRecWaterIntake;
        private Label lblRestSavings;
        private Label retAge;
        private Label lblCurSav;
        private Label lblMonthSav;
        private Label lblAnnualInterest;
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
        private GroupBox grbGender;
        private GroupBox grbUnit;
        public Label lblMetricIntake;
    }
}
