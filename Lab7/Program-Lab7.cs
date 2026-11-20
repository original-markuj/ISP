Car[] cars = new Car[5];

Random rng = new Random();

int rngYearDate = 0;
int rngMonthDate = 0;
int rngDayDate = 0;

string[] names = new string[5] {"Suzuki", "Toyota", "Honda", "Haval", "Markuj Mobile"};

for (int i = 0; i < cars.Length; i++)
{
    int rngName = rng.Next(names.Length);
    int rngYear = rng.Next(2000, 2027);
    rngYearDate = rngYear - rng.Next(1, 5);
    rngMonthDate = rng.Next(1, 13);
    rngDayDate = rng.Next(1, 29);



    cars[i].name = names[rngName];
    cars[i].creator = $"{names[rngName]} INC";
    cars[i].maxMass = rng.Next(2, 6);
    cars[i].releaseYear = rngYear;
    cars[i].dateOfRegistration = $"{rngDayDate}.{rngMonthDate}.{rngYearDate}";
}

for (int i = 0; i < cars.Length; i++)
{
    cars[i].print();
    Console.WriteLine("\n");
}

Console.WriteLine("Entertaining conditions:");

for (int i = 0; i < cars.Length; i++)
{
    if (((rngYearDate < 2026 && rngMonthDate < 11 && rngDayDate < 20) || (rngYearDate < 2025)) && cars[i].maxMass > 3)
    {
        cars[i].print();
        Console.WriteLine("\n");
    }
}

struct Car
{
    public string name;
    public string creator;
    public int maxMass;
    public int releaseYear;
    public string dateOfRegistration;
    public void print()
    {
        Console.Write($"Name: {name}; Creator: {creator}; Max mass: {maxMass}; Release year: {releaseYear}; Registration Date: {dateOfRegistration}");
    }
}