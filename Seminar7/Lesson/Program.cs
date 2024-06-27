// int Fact(int n)
// {
//     if(n == 1)
// {
//     Console.WriteLine($"Stop requrson: n={n}");
//     return 1;
// }
// Console.WriteLine(n);
// return n * Fact(n-1);
// }

// Console.WriteLine(Fact(5));

int Fact(int n)
{
if(n == 1)
{
    Console.WriteLine($"Stop requrson: n={n}");
    return 1;
}
Console.WriteLine(n);
int res = n * Fact(n - 1);
System.Console.WriteLine($"Возврат: n={n}, fact={res}");
return res;
}
Console.WriteLine(Fact(5));