// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите через пробел  координаты X Y Z точки А:");
string xAyAzA = Console.ReadLine ()!; 
string [] partsA = xAyAzA.Split(' ');  
int xA = int.Parse (partsA[0]); 
int yA = int.Parse (partsA[1]);
int zA = int.Parse (partsA[2]);

Console.WriteLine("Введите через пробел  координаты X Y Z точки B:");
string xByBzB = Console.ReadLine ()!; 
string [] partsB = xByBzB.Split(' ');  
int xB = int.Parse (partsB[0]); 
int yB = int.Parse (partsB[1]);
int zB = int.Parse (partsB[2]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние между двумя точками равно {distance:F2} единиц.");
