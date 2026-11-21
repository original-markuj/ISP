//Вариант 13 Средний Уровень
Car[] cars = new Car[5];

Random rng = new Random();

DateTime temp = DateTime.Now;
DateOnly dateNow = new DateOnly(temp.Year,temp.Month,temp.Day);

int rngYearDate = 0;
int rngMonthDate = 0;
int rngDayDate = 0;

string[] names = new string[7] { "Suzuki", "Toyota", "Honda", "Haval", "Markuj Mobile", "BMW", "Volkswagen" };

for (int i = 0; i < cars.Length; i++)
{
    int rngName = rng.Next(names.Length);
    int rngYear = rng.Next(2000, 2027);
    rngYearDate = rngYear - rng.Next(1, 5);
    rngMonthDate = rng.Next(1, 13);
    if (rngMonthDate == 2) rngDayDate = rng.Next(1, 29);
    else if ((rngMonthDate % 2 == 1 && rngMonthDate <= 7) || (rngMonthDate % 2 == 0 && rngMonthDate > 7)) rngDayDate = rng.Next(1, 32);
    else if ((rngMonthDate % 2 == 0 && rngMonthDate <= 7) || (rngMonthDate % 2 == 1 && rngMonthDate > 7)) rngDayDate = rng.Next(1, 31);

    DateOnly rngDate = new DateOnly(rngYearDate,rngMonthDate,rngDayDate);

    cars[i].name = names[rngName];
    cars[i].creator = $"{names[rngName]} INC";
    cars[i].maxMass = rng.Next(2, 6);
    cars[i].releaseYear = rngYear;
    cars[i].dateOfRegistration = rngDate;
}

for (int i = 0; i < cars.Length; i++)
{
    cars[i].print();
    Console.WriteLine("\n");
}

Console.WriteLine("Entertaining conditions:");

for (int i = 0; i < cars.Length; i++)
{
    if ((cars[i].dateOfRegistration < dateNow.AddYears(-1)) && cars[i].maxMass > 3)
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
    public DateOnly dateOfRegistration;
    public void print()
    {
        Console.Write($"Name: {name}; Creator: {creator}; Max mass: {maxMass}; Release year: {releaseYear}; Registration Date: {dateOfRegistration}");
    }
}