Console.Clear();
Console.WriteLine("ВВедите число");
int x = Convert.ToInt32(Console.ReadLine());
if (x<=0) Console.WriteLine("число должно быть положительным");
else
{
int[] n = new int[x];
for (int i =0; i< n.Length; i++)
{
    n[i] = Convert.ToInt32(Math.Pow(i+1, 3));
    Console.Write(n[i]);
    if (i< n.Length-1) Console.Write(", ");
}
Console.WriteLine();
}