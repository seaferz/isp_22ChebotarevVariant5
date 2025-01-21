/*
 * Даны натуральные n, a1,..., an(n >=4) числа a1..., an – это измеренные в сотых долях 
 * секунды результаты n спортсменов в беге на 100 м. Составить команду из четырех лучших 
 * бегунов для участия в эстафете 4х100, т. е. указать одну из четверок натуральных чисел i, 
 * j, k, l такую, что сумма a1+aj+ak+ac имеет наименьшее значение. 
*/

int[] timesArray = { 1250, 1300, 1100, 1450, 1200, 1150 };

Array.Sort(timesArray);


//Take(n) - берет первые (n) элементов
int minTime = timesArray.Take(4).Sum();

Console.WriteLine("Лучшие спортсмены: ");
Console.WriteLine($"Результаты: {timesArray[0]}, {timesArray[1]}, {timesArray[2]}, {timesArray[3]}");
Console.WriteLine($"Минимальная сумма: {minTime}");



//по циклам

//int[] timesArray = { 1250, 1300, 1100, 1450, 1200, 1150 };

//int minTime = int.MaxValue;
//int bestI = 0, bestJ = 0, bestK = 0, bestL = 0;

//for (int i = 0; i < timesArray.Length - 3; i++)
//{
//    for (int j = i + 1; j < timesArray.Length - 2; j++)
//    {
//        for (int k = j + 1; k < timesArray.Length - 1; k++)
//        {
//            for (int l = k + 1; l < timesArray.Length; l++)
//            {
//                int sum = timesArray[i] + timesArray[j] + timesArray[k] + timesArray[l];

//                if (minTime > sum)
//                {
//                    minTime = sum;
//                    bestI = i;
//                    bestJ = j;
//                    bestK = k;
//                    bestL = l;
//                }
//            }
//        }
//    }
//}
//// вывод результата
//Console.WriteLine("Лучшие спортсмены: ");
//Console.WriteLine($"Индексы: {bestI}, {bestJ}, {bestK}, {bestL}");
//Console.WriteLine($"Результаты: {timesArray[bestI]}, {timesArray[bestJ]}, {timesArray[bestK]}, {timesArray[bestL]}");
//Console.WriteLine($"Минимальная сумма: {minTime}");
