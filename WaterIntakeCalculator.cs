using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



    internal class WaterIntakeCalculator(Person person)
    {
        public static double CalculateWaterIntake(string gender, int age, double weight, double height, string activityLevel)
    {

        double baseIntake = BaseIntake(weight);

        double genderIntake = GenderIntake(GenderParse(gender));
        double ageIntake = AgeIntake(age);
        double heightIntake = HeightIntake(height);
        double activityLevels = ActivityLevels(ActivityLevelParse(activityLevel));

        return recomendedIntake = baseIntake * genderIntake * ageIntake * heightIntake * activityLevels;


    }
    //method to get calculate total water intake based on weight
    private static double BaseIntake(double weight)
    {
        return 33 * weight;
    }

    public static double GenderIntake(Gender gender)
    {
        switch (gender)
        {
            case Gender.Female:
                    return 0.9; //decrease by ten percent
            case Gender.Male:
                    return 1.1; //increase by ten percent
            case Gender.Them:
                    return 1.0; //no change for other gender
            default: 
                return 1.0;
        }
    }
    //method to parse the gender enum to string 
   public static Gender GenderParse(string gender)
    { 
    switch (gender.ToLower()) 
    {
            case "female":
                return Gender.Female;
            case "male":
                return Gender.Male;
            case "other":
                return Gender.Them;
        default:
                return Gender.Them;
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
    public static double ActivityLevels(ActivityLevel activityLevel)
    {

        //set activity level to low as standard if no valid input, but no input not likely

        switch (activityLevel)
        {
            case ActivityLevel.Low:
                activityLevel = ActivityLevel.Low;
                return 1.0;
            case ActivityLevel.Medium:
                activityLevel = ActivityLevel.Medium;
                return 1.2;
            case ActivityLevel.High:
                activityLevel = ActivityLevel.High;
                return 1.5;
            default:
                activityLevel = ActivityLevel.Low;
                return 1.0;
        }
    }
    //method to parse enum to strings to pass as argument in CalculateWaterIntake method
    public static ActivityLevel ActivityLevelParse(string activityLevel)
    {
        ActivityLevel activitylevel;

            switch (activityLevel.ToLower())
        {
            case "low":
                return ActivityLevel.Low;
            case "medium":
                return ActivityLevel.Medium;
            case "high":
                return ActivityLevel.High;
            default:
                return ActivityLevel.Low;
        }
    }

    private void DisplayWaterIntake(Person person)
    {
        double dailyIntake = WaterIntakeCalculator.CalculateWaterIntake
            (
            person.Gender,
            person.Age,
            person.Weight,
            person.Height,
            person.ActivityLevel
            );

        double dailtyintakeImperial = Conversion.MlToOz(dailyIntakeMetric);

    }






   



}

    


