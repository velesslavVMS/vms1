Console.Write("Введите первое число (k): ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

if(k>m && k>n)
{
    Console.WriteLine(k);
    }
else if(m>=n)
 Console.WriteLine(m);
 else
  Console.WriteLine(n);
 