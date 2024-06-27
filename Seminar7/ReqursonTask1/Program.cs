// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


void Main()
{
    int M = ReadInt("Введите 1ое число: ");
    int N = ReadInt("Введите 2ое число: ");
    System.Console.WriteLine(ShowNumbers(M, N));
}

string ShowNumbers(int M,int N)
{
  if  (M != N)
  {
    if (M > N)
    {
      return $"{N} " + ShowNumbers( M , N + 1 );
    } 
    else
    {
      return $"{M} " + ShowNumbers( M + 1 , N );
    }
  }
  else
  {
    return $"{N}";
  }

}


int ReadInt(string msg)
{
System.Console.Write(msg);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
Main();
