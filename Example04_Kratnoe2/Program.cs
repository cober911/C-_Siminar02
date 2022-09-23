/* Проверить является ли введённое число кратное 7 и 23. 
14 нет
46 нет
161 да */


int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNumber();

if(number % 7 ==0 && number % 23 ==0)
Console.WriteLine($"Число {number} кратно");
else
Console.WriteLine($"Число {number} не кратно");