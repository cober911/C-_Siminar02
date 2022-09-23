/* Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому.
Если число не кратно числу 1, то вывести об этом сообщение.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
int result = firstNumber % secondNumber;

if(firstNumber % secondNumber == 0)
   Console.WriteLine("Кратно");
else
   Console.WriteLine($"Не кратно {result}");