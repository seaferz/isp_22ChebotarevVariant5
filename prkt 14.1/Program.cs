/*
Описать процедуру SortInc3(A, B, C), меняющую содержимое переменных A, B, C
таким образом, чтобы их значения оказались упорядоченными по возрастанию (A, B, C 
— вещественные параметры, являющиеся одновременно входными и выходными). С 
помощью этой процедуры упорядочить по возрастанию два данных набора из трех чисел: 
(A1, B1, C1) и(A2, B2, C2).
*/

void SortInc3(ref double a, ref double b, ref double c)
{
    if (a > b)
    {
        var temp = a;
        a = b;
        b = temp;
    }

    if (b > c)
    {
        var temp = b;
        b = c;
        c = temp;
    }

    if (a > b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}

var trys = 0;

while (trys < 2)
{
    Console.Write("Введи a: ");
    var A = double.Parse(Console.ReadLine());

    Console.Write("Введи b: ");
    var B = double.Parse(Console.ReadLine());

    Console.Write("Введи c: ");
    var C = double.Parse(Console.ReadLine());

    SortInc3(ref A, ref B, ref C);

    Console.WriteLine();

    if (trys == 0)
    {
        Console.WriteLine($"A1: {A}, B1: {B}, C1: {C}\n");
    }
    else
    {
        Console.WriteLine($"A2: {A}, B2: {B}, C2: {C}");
    }

    trys++;
}