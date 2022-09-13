// Программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

Console.WriteLine("Введите число N из натуральнго ряда, кроме N=0");
int number = int.Parse(Console.ReadLine()!);

OutCub(number);

int OutCub(int number)
{
    if (number == 0)
        Console.WriteLine("N = 0 не соответствует условиям задачи. Повторите ввод N ");
    int cub = 0;
    for (int i = 1; i <= number; i++) // 1, 2, 3 .... N
    {
        cub = i * i * i;
        Console.WriteLine($" Куб числа {i} равен {cub}");
    }
    return cub;
}
