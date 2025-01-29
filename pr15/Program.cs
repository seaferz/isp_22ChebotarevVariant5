using NumberLibrary; // Подключаем пространство имен библиотеки

int number = 1234;
int divider = 6;

Console.WriteLine($"Равны ли суммы первых двух и последних двух цифр? {NumberAnalyzer.SumOfFirstTwoDigits(number)}");
Console.WriteLine($"Кратна ли сумма цифр трём? {NumberAnalyzer.IsSumDivisibleByThree(number)}");
Console.WriteLine($"Кратно ли произведение цифр числу {divider}? {NumberAnalyzer.IsProductDivisibleByA(number, divider)}");