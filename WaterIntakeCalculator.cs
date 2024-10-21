using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



    internal class WaterIntakeCalculator(Person person)
    {
    private Person person = new Person();
    double baseIntake = 33;
    public float recomendedIntake;

    //method to get calculate total water intake based on weight
    public static double BaseIntake(double weight)
    {
        return 33 * weight;
    }

    public static double GenderIntake(string gender)
    {
        if (gender == "female")
        {
            return 0.9; //decrease by ten percent
        }
        else if (gender == "male")
        {
            return 1.1; //increase by ten percent
        }
        else if (gender == "other")
        {
            return 1.0; //no change for other gender
        }
    }

    public static double AgeIntake(int age)
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

    public static double HeightIntake(double height)
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
    public static double ActivityLevels(string activityLevel)
    {
        //activity level variable declared
        ActivityLevel activitylevel;
        //set activity level to low as standard if no valid input, but no input not likely
        switch (activitylevel)
        {
            case "low":
                activitylevel = ActivityLevel.Low;
                return 1.0;
            case "medium":
                activitylevel = ActivityLevel.Medium;
                return 1.2;
            case "high":
                activityLevel = ActivityLevel.High;
                return 1.5;
            default:
                activitylevel = ActivityLevel.Low;
                return 1.0;
        }
    }
    public static double CalculateWaterIntake(string gender, int age, double weight, double height, string activityLevel)
    {
        double baseIntake = BaseIntake(weight);

        double genderIntake = GenderIntake(gender);
        double ageIntake = AgeIntake(age);
        double heightIntake = HeightIntake(height);
        double activityLevels = ActivityLevels(activityLevel);

        recomendedIntake = baseIntake * genderIntake * ageIntake * heightIntake * activityLevels;
        return recomendedIntake;

    }




   



}

    


