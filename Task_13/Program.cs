// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());

void Main(int number)
{
    
    int thirdDigit = GetThirdDigit(number);
    if (thirdDigit == -1)
    {
        Console.WriteLine("No third digit");
    }
    else
    {
        Console.WriteLine("Third digit number is " + thirdDigit);
    }
    //Console.ReadLine();
}
int GetThirdDigit(int number)
{
    if (number <=99)
    {
        return -1; //флаг отсутствия третьей цифры
    }
    int result = 0;
    while (number > 0)//перевернуть число наоборот
    {
        int digit = number%10;
        result = (result*10)+digit;
        number /=10;
    }
    number = result;
    return (number/100)%10;//вычисление третьей цифры
}
Main(number);
