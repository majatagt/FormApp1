


public class Person
{
    public string Name { get; set; }
    public double Weight { get; set; } // public with a private setter for outside access
    public double Height { get; set; } // Same as above
    public EGender Gender { get; set; } // Same as above
    public EActivityLevel ActivityLevel { get; set; }
    public int Age { get; set; } // Age is calculated and should be private to control changes



    public Person(string name, double weight, double height, int age, EGender gender, EActivityLevel activityLevel) 
    {
        Name = name;
        Weight = weight;
        Height = height;
        Age = age;
        Gender = gender;
        ActivityLevel = activityLevel;
    }

        public EGender GetGender()
        {
        if (Gender == EGender.Male)
            return EGender.Male;
        if (Gender == EGender.Female)
            return EGender.Female;
        else
            return EGender.Them;
        }
        
    }




