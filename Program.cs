int Calcul(int num1, int num2, string doing)
{
    int result = 0;
    if (doing == "+")
    {
        result = num1 + num2;
        return result;
    }
    if (doing == "-")
    {
        result = num1 - num2;
        return result;
    }
    if (doing == "/")
    {
        result = num1 / num2;
        return result;
    }
    if (doing == "*")
    {
        result = num1 * num2;
        return result;
    }
    return result;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("+ если сложить, - если отнять, / если раздеить, * если умножить");
string? doing = Convert.ToString(Console.ReadLine());
#nullable disable
Console.Write(Calcul(num1, num2, doing));
