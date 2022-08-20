// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void FillArray(int[] collection)
{
    for (int i = 0; i < 3; i++)
    {
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }

}

Console.Write("Введите координаты прервой точки:\n");
int[] firstDot = new int[3];
FillArray(firstDot);

Console.Write("Введите координаты второй точки:\n");
int[] secondDot = new int[3];
FillArray(secondDot);

double distance = Math.Sqrt(Math.Pow(secondDot[0] - firstDot[0], 2) + Math.Pow(secondDot[1] - firstDot[1], 2) + Math.Pow(secondDot[2] - firstDot[2], 2));
Console.WriteLine($"Расстояние = {distance:f2}");