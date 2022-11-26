//  Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int count)
{
    int sum = 0;

    while (count > 0)
    {
        sum += count % 10;
        count /= 10;
    }
    return sum;
}
Console.WriteLine("Сумма цифр в числе =: "+SumNum(num));