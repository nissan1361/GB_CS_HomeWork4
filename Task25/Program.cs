// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

// Input
int numA = GetUserNum();
int numB = GetUserNum();

// Logic
int result = PowerNum(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {result}");

// Methods
static int GetUserNum()
{
    while (true)
    {
        int num;
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out num))
        {
            return num;
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода! ");
        }
    }
}

static int PowerNum(int num1, int numPow)
{
    int result = 1;
    for (int i = 0; i < numPow; i++)
    {
        result *= num1;
    }

    return result;
}