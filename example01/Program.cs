<<<<<<< HEAD
﻿/*Напишите программу, которая выводит случайое число из отрезка [10, 99]
и показываеит наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int GetRandomNumber(int leftRange, int RightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, RightRange); 
    return result;
}    

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit>secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 100);
Console.WriteLine($"Рандомное число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine($"Максимальная цифра: {maxDigit}");
=======
﻿
>>>>>>> 61d46343288ede2a0331b5f1d677fc2482e43ed8
