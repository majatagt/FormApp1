


    internal class Person
    {
    private string Name { get; set; }
    private double Weight { get; set; }
    private double Height { get; set; }
    private string Gender { get; set; }
    private int YearOfBirth { get; set; }
    private string ActivityLevel { get; set; }


    internal Person(string name, double weight, double height, int age)
    {
        Name = name;
        Weight = weight;
        Height = height;
        YearOfBirth = age;
    }

    public void CalculateAge(int yearOfBirth)//calculate and store age
    {
        int currentYear = DateTime.Now.Year;
        int Age = currentYear - yearOfBirth;

    }

    

}

    

