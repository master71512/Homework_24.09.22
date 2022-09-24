Console.Clear();
Console.Write("Введите 5-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num<10000) | (num > 99999)) Console.WriteLine("число не 5-значное");
else
{
    if((num / 10000 == num % 10) & (num / 1000 % 10 == num % 100 / 10)) Console.WriteLine("да");
    else Console.WriteLine("нет");
}