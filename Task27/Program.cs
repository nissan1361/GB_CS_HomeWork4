// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int number = int.Parse(Console.ReadLine());
int answer = SumInNum(number);

Console.WriteLine($"{number} -> {answer}");

static int SumInNum(int numb)
{
    int sum = 0;
    while (numb > 0)
    {
        sum += numb % 10;
        numb = numb / 10;
    }

    return sum;
}
