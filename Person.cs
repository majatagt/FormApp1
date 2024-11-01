


internal class Person
{
    public string Name { get; set; }
    public double Weight { get; private set; } // public with a private setter for outside access
    public double Height { get; private set; } // Same as above
    public string Gender { get; private set; } // Same as above
    public int YearOfBirth { get; private set; } //public with a private setter
    public string ActivityLevel { get; private set; }
    public int Age { get; private set; } // Age is calculated and should be private to control changes



    internal Person(string name, double weight, double height, int age, string gender = null) // gender is declared in the constructor, and needs to be handled as such
    {
        Name = name;
        Weight = weight;
        Height = height;
        YearOfBirth = age;

        public void Gender GetGender()
        {
            if (rbFemale.Checked)
            {
                return Gender.Female;
            }
            else if (rbMale.Checked)
            {
                return Gender.Male;
            }
            else if (rbThem.Checked)
            {
                return Gender.Them;
            }
            return Gender.Them;

        }
    }

// unclear what this method should do. do you want to change this object directly with 'Age = Age_theVariable' or do you want to 'return Age_theVariable' for use somewhere else?
    public  void CalculateAge(int yearOfBirth)//calculate from given input of year and store age in Age variable
    {
        int currentYear = DateTime.Now.Year;
        int Age_theVariable = currentYear - yearOfBirth; // this Age needs to be stored in the object, or returned
        Age = Age_theVariable; // what is Age here?
    }
}

