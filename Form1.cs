using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace FormApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
            cbActivityLevel.DataSource = Enum.GetValues(typeof(EActivityLevel));

        }

        public void InitializeGUI() //method to instansiate app and clear text boxes, and pre select gender and unit
        {

            txtboxHeight.Text = String.Empty;
            txtbName.Text = String.Empty;
            txtboxWeight.Text = String.Empty;
            txtbBirthYear.Text = String.Empty;
            rbMetric.Checked = true;
            rbfemale.Checked = true;

        }

        private void rbMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxWeight.Text) && !String.IsNullOrEmpty(txtboxHeight.Text))
            {
                {

                    double height = Convert.ToDouble(txtboxWeight.Text);
                    double weight = Convert.ToDouble(txtboxHeight.Text);
                    double convertedWeight, convertedHeight;

                    if (!double.TryParse(txtboxHeight.Text, out height) || height <= 0)
                    {
                        MessageBox.Show("Enter a valid number!");
                        return;
                    }
                    if (!double.TryParse(txtboxWeight.Text, out weight) || weight <= 0)
                    {
                        MessageBox.Show("Enter a valid number!");
                        return;
                    }


                    if (rbMetric.Checked)
                    {
                        //setUnit = Unit.Metric;
                        convertedWeight = Conversion.PoundsToKg(weight);
                        convertedHeight = Conversion.InchToCm(height);
                        

                    }
                    else
                    {
                        // setUnit = Unit.Imperial;
                        convertedWeight = Conversion.KgToPounds(weight);
                        convertedHeight = Conversion.CmToInch(height);

                    }
                    //txtboxWeight.Text = convertedWeight.ToString("F2");
                    //txtboxHeight.Text = convertedHeight.ToString("F2");
                }
            }

        }
        //populating the combo box with enum of Activity Levels and pre populating the first box to low level of activity
        private void cbActivityLevel_SelectedIndexChange(object sender, EventArgs e)
        {
            EActivityLevel setActivityLevel = (EActivityLevel)cbActivityLevel.SelectedItem; // kan du förklara vad du gör här?
            cbActivityLevel.SelectedIndex = (int)EActivityLevel.Low;
        }

        //failure handling to accept numerical input and values greater than 0. If 2/3 input fields are correct, error message prevails
        public void button1_Click(object sender, EventArgs e)
        {

            string name = txtbName.Text;
            double height;
            double weight;
            int birthYear;
            EGender gender;


            EActivityLevel activityLevel = (EActivityLevel)Enum.Parse(typeof(EActivityLevel), cbActivityLevel.SelectedItem.ToString()); //cbActivityLevel.SelectedItem;

            if (!double.TryParse(txtboxHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("Enter a valid number!");
                return;
            }
            if (!double.TryParse(txtboxWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Enter a valid number!");
                return;
            }
            if (!int.TryParse(txtbBirthYear.Text, out birthYear) || birthYear <= 0)
            {
                MessageBox.Show("Enter a valid number!");
                return;
            }

            // Write a Function checking the RB Boxes for Which Gender To Set.
            gender = GetEGender();
            int age = GetAge();


            // try this instead
            // Instantiate a person with properties set based on valid input
            var person = new Person(name, weight, height, age, gender, activityLevel);

            WaterIntakeCalculator waterIntakeCalculator = new WaterIntakeCalculator(person);
            var recomendedIntake = waterIntakeCalculator.CalculateWaterIntake();
            
         
            lblMetricIntake.Text = recomendedIntake.ToString();


        }

        private int GetAge()
        {
            // Bug here - What is they DATE of birth is in April and Currently its Janurary;
            // This will create them being older then currently are.
            return DateTime.Now.Year - int.Parse(txtbBirthYear.Text);
        }

        private EGender GetEGender()
        {
            if (rbfemale.Checked)
            {
                return EGender.Female;
            }

            if (rbMale.Checked)
            {
                return EGender.Male;
            }

            if (rbOther.Checked)
            {
                return EGender.Them;
            }


            return EGender.Them;
        }



    }
}

