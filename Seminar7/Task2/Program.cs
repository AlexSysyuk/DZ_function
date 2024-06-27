// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
    int M = ReadInt("Введите неотрицательное число M: ");
    int N = ReadInt("Введите неотрицательное число N: ");
    System.Console.WriteLine($"Значение функции Аккермана - А({M}, {N}) равно:{AckermanFunction(M, N)}");
}

int AckermanFunction(int M, int N)
{
    if (M < 0 || N < 0)
    {
        Console.WriteLine("Введите неотрицательные числа!!!");
        return 0;
    }
    else
    {
        if (M > 0 && N > 0) 
        {
            return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
        }
        else 
        {
            if (M > 0 && N == 0) 
            {
            return AckermanFunction(M - 1, 1);
            }
            else 
            {
                if (M == 0 && N > 0)  
                {
                    return N + 1;
                }
            }
        }

    return 0;
    }
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}
Main();