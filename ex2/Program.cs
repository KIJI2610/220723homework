Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = SumDigits(num);
Console.WriteLine("Сумма цифр в числе: " + sum);
static int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
            sum += num % 10;
            num /= 10; 
    }
    return sum;
}