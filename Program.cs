// Задча 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void numbers (int num)
{
    int number1 = num / 10000;
    int number2 = num / 1000 % 10;
    int number4 = num % 100 / 10;
    int number5 = num % 10;

    if(number1 == number5 && number2 == number4)
    Console.WriteLine($"Число {num} палиндром.");
    else
    Console.WriteLine($"Число {num} не палиндром.");
}

Console.WriteLine("Введите пятизначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb > 9999 && numb < 100000)
{
    numbers (numb);
}
else
Console.WriteLine("Ошибка ввода!");
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double LongLine (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return lengthAB;
}

Console.WriteLine("Input x coordinat of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y coordinat of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input z coordinat of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x coordinat of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y coordinat of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input z coordinat of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance AB is {dist:f2}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void CubeFinder ()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if(numberN >0)
    {
        int current_i = 1;
        while(current_i <= numberN)
        {
        int res = current_i*current_i*current_i;
        Console.Write($"{res}, ");
        current_i++;
        }
        Console.WriteLine("\b\b.");
    }
    else Console.WriteLine("Impossible value!");
}

CubeFinder();
*/