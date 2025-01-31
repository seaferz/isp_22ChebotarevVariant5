using NumberLibrary; // Подключаем пространство имен библиотеки

Console.Write("Введите четырёхзначное число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите число A для проверки на кратность: ");
int divider = int.Parse(Console.ReadLine());

Console.WriteLine($"Равны ли суммы первых двух и последних двух цифр? {NumberAnalyzer.SumOfFirstTwoDigits(number)}");
Console.WriteLine($"Кратна ли сумма цифр трём? {NumberAnalyzer.IsSumDivisibleByThree(number)}");
Console.WriteLine($"Кратно ли произведение цифр числу {divider}? {NumberAnalyzer.IsProductDivisibleByA(number, divider)}");