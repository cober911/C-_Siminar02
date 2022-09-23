/* Напишите программу, которая принимает на вход два числа
и проверяет, является ли одно число квадратом другого.
5, 25 да
-4, 16 да
25, 5 да
8, 9 нет 
1. Создали функцию вводим два числа
2. Привести два числа к модулю
3. Надо найти минимальное из этих чисел и поделить 
максимальное на минимальное
4. Если результат от деления равен минимальному числу то число кратно
*/

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
firstNumber = Math.Abs(firstNumber); // Math.Abs() это модуль числа
secondNumber = Math.Abs(secondNumber);

if(firstNumber > secondNumber)
{
 if (firstNumber / secondNumber == secondNumber)
 Console.WriteLine("Да");
 else
 Console.WriteLine("Нет");
}
else if(firstNumber < secondNumber)
{
 if (secondNumber / firstNumber == firstNumber)
 Console.WriteLine("Да");
 else
 Console.WriteLine("Нет");
}

