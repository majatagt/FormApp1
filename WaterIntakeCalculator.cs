using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



public class WaterIntakeCalculator
{
    public Person _person { get; set; }
    public WaterIntakeCalculator(Person person)
    {
        _person = person;
    }
    public double CalculateWaterIntake()
    {
        var baseIntake = BaseIntake(_person.Weight);
        var height = HeightIntake(_person.Height);
        var gender = GenderIntake(_person.Gender);
        var age = AgeIntake(_person.Age);
        var activitylevel = ActivityLevels (_person.ActivityLevel);

        return baseIntake * gender * age * height * activitylevel;


    }
    //method to get calculate total water intake based on weight
    public double BaseIntake(double weight)
    {
        return 33 * weight;
    }

    public double GenderIntake(EGender gender)
    {
        switch (gender)
        {
            case EGender.Female:
                return 0.9; //decrease by ten percent
            case EGender.Male:
                return 1.1; //increase by ten percent
            case EGender.Them:
                return 1.0; //no change for other gender
            default:
                return 1.0;
        }
    }


    public double AgeIntake(int age)
    {
        if (age < 30)
        {
            return 1.1; //increase by 10 for over 30
        }
        else if (age > 55)
        {
            return 0.9; //decrease if over 55
        }
        return 1.0; // if between 30 and 55, no adjustment
    }

    public double HeightIntake(double height)
    {
        if (height > 175) //if over 175 cm
        {
            return 1.05;
        }
        else if (height < 160) // if shorter than 160
        {
            return 0.95;
        }
        return 1.0; // if between 160 and 175
    }
    public double ActivityLevels(EActivityLevel activityLevel)
    {

        //set activity level to low as standard if no valid input, but no input not likely

        switch (activityLevel)
        {
            case EActivityLevel.Low:
                return 1.0;
            case EActivityLevel.Medium:
                return 1.2;
            case EActivityLevel.High:
                return 1.5;
            default:
                return 1.0;
        }
    }










}




