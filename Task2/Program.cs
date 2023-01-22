int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalAmount(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalAmount(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalAmount(m, n - 1);
}