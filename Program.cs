void Task1()
/*Используя определенные степени числа, напишисать цикл, который принимает на вход два натуральных числа числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3)
2, 4 -> 16
*/
{
    int numberA = ReadInt("Введите число A: ");
    int numberB = ReadInt("Введите число B: ");
    ToDegree(numberA, numberB);

    void ToDegree(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        Console.WriteLine(a + "B  в степени " + b + result);
    }
    int ReadInt(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}

void Task2()
/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
{
    int number = ReadInt("Введите число : ");

    int Len = NumberLen(number);
    SumNumbers(number, Len);
    int NumberLen(int a)
    {
        int index = 0;
        while (a > 0)
        {
            a /= 10;
            index++;
        }
        return index;
    }
    void SumNumbers(int n, int Len)
    {
        int sum = 0;
        for (int i = 1; i <= Len; i++)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine($"суммы цифр {sum}");
    }
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}


void Task3()
/*Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [6, 1, -33]
*/
{
    int LenArray = ReadInt("Введите длинну массива: ");
    int[] randomArray = new int[LenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1, 9);
        Console.Write(randomArray[i] + " ");
    }
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}


void Task4()
/*Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [6, 1, -33]
*/
{
int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " ");
}
}
Task3();