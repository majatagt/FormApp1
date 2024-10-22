


    internal class Person
    {
    public string Name { get; set; }
    private double Weight { get; set; }
    private double Height { get; set; }
    private string Gender { get; set; }
    private int YearOfBirth { get; set; }
    private string ActivityLevel { get; set; }


    internal Person(string name, double weight, double height, int age, string gender)
    {
        Name = name;
        Weight = weight;
        Height = height;
        YearOfBirth = age;
    }

    public Person()
    {
    }

    public void CalculateAge(int yearOfBirth)//calculate from given input of year and store age in Age variable
    {
        int currentYear = DateTime.Now.Year;
        int Age = currentYear - yearOfBirth;

    }

    

}

    

