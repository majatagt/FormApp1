using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        private Gender setGender; //variable to store gender of person, stored as enum
        private Unit setUnit; //variable to store unit chosen, stored as enum
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //method to check which radio button is checked and set gender
        {
            if (rbfemale.Checked)
            {
                setGender = Gender.Female;
            }
            else if (rbMale.Checked)
            {
                setGender = Gender.Male;
            }
            else if (rbOther.Checked)
            {
                setGender = Gender.Them;
            }
        }
        private void rbMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetric.Checked)
            {
                setUnit = Unit.Metric;
            }
            else
            {
                setUnit = Unit.Imperial;
            }
        }

        private void cbActivityLevel_SelectedIndexChange(object sender, EventArgs e)
        {
            ActivityLevel setActivityLevel = (ActivityLevel)cbActivityLevel.SelectedItem;
        }

        //failure handling to accept numerical input and values greater than 0. If 2/3 input fields are correct, error message prevails
        private void button1_Click(object sender, EventArgs e)
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


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
