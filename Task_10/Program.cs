// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());

void Main(int number)
{
    
    int secondDigit = GetSecondDigit(number);
    if (secondDigit == -1)
    {
        Console.WriteLine("Out of limit");
    }
    else
    {
        Console.WriteLine("Second digit number is " + secondDigit);
    }
    //Console.ReadLine();
}
int GetSecondDigit(int number)
{
    if (number <=99 || number >=1000)
    {
        return -1; //флаг не трехзначного числа
    }
    
    return (number/10)%10;//вычисление второй цифры
}
Main(number);