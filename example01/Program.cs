/*Напишите программу, которая выводит случайое число из отрезка [10, 99]
и показываеит наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int GetRandomNumber(int leftRange, int rightRange)
{
 Random rnd = new Random();
 int result = rnd.Next(leftRange, rightRange);
 return result;
}

int GetMaxDigitOfNumber(int numer)
{
    int firstDigit= GetRandomNumber /10;
    int secondDigit = GetRandomNumber % 10;

}


