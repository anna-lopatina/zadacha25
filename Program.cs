// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int a, int b)
{
    int stepen = a;
    for (int i = 1; i < b; i++)
    {
        stepen = stepen * a;
    }
    return (stepen);
}

Console.Clear();
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());


Console.WriteLine($"A в степени B равно: {Stepen(A,B)}");
