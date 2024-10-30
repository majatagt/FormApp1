using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        // these should not be here. What class gets these fields? Spoiler, its Form1.
        // Why is this bad? Coupling. A Form should only have fields that relates to the function of a Form.
        // These variables are really for a Person.
        // Use the GUI controls in this class to represent these values, but do not store them like this.

        // private Gender setGender; //variable to store gender of person, stored as enum -- I think youre attempting to use this as a method... but this is a field :)
        // private Unit setUnit; //variable to store unit chosen, stored as enum
        // string name;
        // double height;
        // double weight;
        // int birthYear;


        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
            cbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel));

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
                setUnit = Unit.Metric;
                convertedWeight = Conversion.PoundsToKg(weight);
                convertedHeight = Conversion.InchesToCm(height);
            }
            else
            {
                setUnit = Unit.Imperial;
                convertedWeight = Conversion.KgToPounds(weight);
                convertedHeight = Conversion.CmToInch(height);
            }
            txtboxWeight.Text = convertedWeight.ToString("F2");
            txtboxHeight.Text = convertedHeight.ToString("F2");
        }


        //populating the combo box with enum of Activity Levels and pre populating the first box to low level of activity
        private void cbActivityLevel_SelectedIndexChange(object sender, EventArgs e)
        {
            ActivityLevel setActivityLevel = (ActivityLevel)cbActivityLevel.SelectedItem; // kan du förklara vad du gör här?
            cbActivityLevel.SelectedIndex = (int)ActivityLevel.Low;
        }

        //failure handling to accept numerical input and values greater than 0. If 2/3 input fields are correct, error message prevails
        public void button1_Click(object sender, EventArgs e)
        {
            string name = txtbName.Text;
            double height;
            double weight;
            int birthYear;

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
            // call method to instansiate person based on correct input
            Person person = new Person(); // ok but this does not instantiate a correct person, this just creates a new empty object

            // try this instead
            // Instantiate a person with properties set based on valid input
            var personWithVariables = new Person
            {
                Name = name,
                Height = height,
                Weight = weight, // Added missing semicolon here
                BirthYear = birthYear
            };

            // we can also get the gender they have set.
            var userSetGender = GetGender();

            personWithVariables.setNewGender(userSetGender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //method to check which radio button is checked and set gender
                {
                    // this entire block could be simplified, setGender just reflect what radiobutton is set

                }

                private Gender GetGender()
                {
                    if (rbfemale.Checked)
                    {
                        return Gender.Female;
                    }
                    else if (rbMale.Checked)
                    {
                        return Gender.Male;
                    }
                    else if (rbOther.Checked)
                    {
                        return Gender.Them;
                    }
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // i recommend you delete all click methods for labels, they serve no purpose
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMonthSav_Click(object sender, EventArgs e)
        {

        }

        private void lblMetricIntake_Click(object sender, EventArgs e)
        {
            //lblMetricIntake.Text = WaterIntakeCalculator();
        }

        private void rstImperial_Click(object sender, EventArgs e)
        {

        }

        private void txtboxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbBirthYear_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txtbName_TextChanged(object sender, EventArgs e, Person person)
        //{
        //    txtbName.Text.Trim();
        //    if (!string.IsNullOrEmpty(txtbName.Text))
        //    {
        //        person.Name = txtbName.Text;
        //    }
        //    else
        //    {
        //        person.Name = "Unknown";
        //    }
        //}
    }
}
