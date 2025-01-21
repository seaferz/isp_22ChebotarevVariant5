/*
 * Напишите программу, которая запрашивает у пользователя размерность массива
 * генерирует массив целых чисел в диапазоне [-1, 25]
 * затем сортирует его методом вставок по возрастанию.
 */

Console.Write("Введите размерность массива: ");
int itemCount = int.Parse(Console.ReadLine());
int[] array = new int[itemCount];

var random = new Random();

for (int i = 0; i < array.Length; i++)  //заполняем массив случайными значениями
{
    array[i] = random.Next(-1, 26);
}


for (int i = 0; i <= array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}

Console.WriteLine();

foreach (var item in array)
{
    Console.Write(item + " ");
}