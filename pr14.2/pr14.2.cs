/* 
 * Описать функцию TriangleP(a, h), находящую периметр равнобедренного 
 * треугольника по его основанию a и высоте h, проведенной к основанию (a и h —
 * вещественные). С помощью этой функции найти периметры трех треугольников, для 
 * которых даны основания и высоты. Для нахождения боковой стороны b треугольника 
 * использовать теорему Пифагора: b2 = (a / 2)2 + h2
*/

double TriangleP(double a, double h)
{

    double b2 = Math.Sqrt((a / 2) * (a / 2) + h * h); //4 16
    double perimeter = a + b2 + b2;
    return perimeter;
}

int trys = 0;
while (trys < 3)
{
    Console.WriteLine("Введите основание треугольника: ");
    double baseOfTheTriangle = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите высоту треугольника: ");
    double heightOfTheTriangle = double.Parse(Console.ReadLine());

    double perimeter = TriangleP(baseOfTheTriangle, heightOfTheTriangle);
    Console.WriteLine($"Периметр треугольника: {perimeter}");
    trys++;
}