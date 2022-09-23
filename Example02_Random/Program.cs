/* Напишите программу которая выводит случайное трёзначное число
и удаляет вторую цифру этого числа.
456->46
782->72
918->98
*/

int GetRandomNumber(int leftRange, int RightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, RightRange);
    return result;
}

int DeleteSecondDigit(int number)
{
    int secondDigit = number / 100;
    int twoDigits = number % 10;
    return secondDigit * 10 + twoDigits;
}

int number = GetRandomNumber(100, 1000);
Console.WriteLine($"Вывод числа: {number}");


int twoDigits = DeleteSecondDigit(number);
Console.WriteLine($"Число без второй цифры: {twoDigits}");
