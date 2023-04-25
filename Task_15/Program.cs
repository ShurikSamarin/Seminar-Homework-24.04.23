// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Input number of day in a week");
int number = int.Parse(Console.ReadLine());

void Main(int number)
{
    
    int day = GetWeekDay(number);
    if (day == -1)
    {
        Console.WriteLine("Out of limit");
    }
    else if(day == 6 || day == 7)
    {
        Console.WriteLine("Today is weekend");
    }
    else
    {
        Console.WriteLine("Today is working day");
    }
    //Console.ReadLine();
}
int GetWeekDay(int number)
{
    if (number <=0 || number >=8)
    {
        return -1; //флаг не дня недели
    }
    
    return (number);//вывод дня недели
}
Main(number);