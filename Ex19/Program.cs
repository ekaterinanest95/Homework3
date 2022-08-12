Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if((number % 100000) / 10000 == (number % 10) && (number % 10000) / 1000 == (number % 100) / 10)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}


