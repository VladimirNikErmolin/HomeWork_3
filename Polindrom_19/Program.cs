//  Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
Console.Write(number);

bool isPolindrom = Polindrom(number);

string txt = isPolindrom == true ? " -> Да, это полиндром" : " -> Нет. Это не полиндром";
Console.WriteLine(txt);


bool Polindrom(string number)
{
    bool check = true;
    for (int i = 0; i < number.Length / 2; i++)
    {
        check = check && number[i] == number[number.Length - i - 1];
    }
    return check;
}

