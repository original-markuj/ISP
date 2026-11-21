//Вариант 13 Средний Уровень
string[] names = new string[] {"ПЕРВЫЙ", "Святыня", "Спас", "ЛеоМакс", "Первый - 2", "Домашний", "Карусель" };

int[,] times = new int[,] { { 10, 18 }, { 22, 4 }, { 0, 8 }, { 6, 12 }, { 18, 0 }, { 22, 6 }, { 0, 6 } };

TimeOnly specificTimeStart = new TimeOnly(22,0);
TimeOnly specificTimeEnd = new TimeOnly(6, 0);

tvStudio[] tvStudios = new tvStudio[6];

Random rng = new Random();

for (int i = 0; i < tvStudios.Length; i++)
{
    int rngYearDate = rng.Next(2000,2027); 
    int rngMonthDate = rng.Next(1, 13);
    int rngDayDate = 0;
    if (rngMonthDate == 2) rngDayDate = rng.Next(1, 29);
    else if ((rngMonthDate % 2 == 1 && rngMonthDate <= 7) || (rngMonthDate % 2 == 0 && rngMonthDate > 7))
        rngDayDate = rng.Next(1, 32);
    else if ((rngMonthDate % 2 == 0 && rngMonthDate <= 7) || (rngMonthDate % 2 == 1 && rngMonthDate > 7))
        rngDayDate = rng.Next(1, 31);

    DateOnly dateOfTechs = new DateOnly(rngYearDate, rngMonthDate, rngDayDate);
    int rngTime = rng.Next(times.GetLength(0));
    TimeOnly timeOfTechsStart = new TimeOnly(times[rngTime, 0], ((rng.Next(0, 2) == 0) ? 30 : 00));
    TimeOnly timeOfTechsEnd = new TimeOnly(times[rngTime, 1], ((rng.Next(0, 2) == 0) ? 30 : 00));


    tvStudios[i].name = names[rng.Next(names.Length)];
    tvStudios[i].dateOfTechWorks = dateOfTechs;
    tvStudios[i].techWorksStart = timeOfTechsStart;
    tvStudios[i].techWorksEnd = timeOfTechsEnd;
}

for (int i = 0; i < tvStudios.Length; i++)
{
    tvStudios[i].printAll();
    Console.WriteLine();
}

Console.Write("Channels with nighttime tech works:\n");

for (int i = 0; i < tvStudios.Length; i++)
{
    if (tvStudios[i].techWorksStart.IsBetween(specificTimeStart,specificTimeEnd) &&
        tvStudios[i].techWorksEnd.IsBetween(specificTimeStart, specificTimeEnd))
    {
        tvStudios[i].printSpecific();
        Console.WriteLine();
    }
    
}

struct tvStudio
{
    public string name;
    public DateOnly dateOfTechWorks;
    public TimeOnly techWorksStart;
    public TimeOnly techWorksEnd;
    public void printAll()
    {
        Console.WriteLine($"Channel name: {name}; Date of tech works start: {dateOfTechWorks};" +
            $"Tech times: {techWorksStart}-{techWorksEnd} ({techWorksEnd-techWorksStart})");
    }
    public void printSpecific()
    {
        Console.WriteLine($"Channel name: {name}; Date of tech works start: {dateOfTechWorks};" +
            $"Tech times: {techWorksStart}-{techWorksEnd}");
    }
}