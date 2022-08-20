// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool palindrom(string number)

{
    for (int i = 0, j = number.Length - 1; i < j; i++, j--)

        if (number[i] != number[j])
            return false;
    return true;

}

bool fiveDigit(string number)
{
    if (Convert.ToInt32(number) < 100000 && Convert.ToInt32(number) > 9999) return true;
    return false;
}

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if (fiveDigit(number))
{
    if (palindrom(number))
    Console.WriteLine($"{number} - палиндром");
else Console.WriteLine($"{number} - не палиндром");
}

else Console.WriteLine($"{number} - не является пятизначным числом"); 