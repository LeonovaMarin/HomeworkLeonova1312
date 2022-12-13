// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

int SumFor (int N)
{
    int result = 0;
    for (int i = M; i <= N; i++) result += i;
    return result;
}

int SumRec (int N)
{
    if (N == 0) return 0;
    else return N + SumRec(N - 1);
}

Console.WriteLine(SumFor(N));
