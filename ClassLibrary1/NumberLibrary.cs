using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace NumberLibrary
{

    public static class NumberAnalyzer
    {
        /// <summary>
        /// равна ли сумма двух первых цифр числа, сумме двух его последних цифр
        /// </summary>
        /// <param name="a">First value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool SumOfFirstTwoDigits(int a)
        {
            if (a < 1000 || a > 9999)
            {
                throw new ArgumentException("Число должно быть четырёхзначным");
            }

            int firstNumber = a / 1000;
            int secondNumber = (a / 100) % 10;
            int thirdNumber = (a / 10) % 10;
            int fourthNumber = a % 10;

           return firstNumber + secondNumber == thirdNumber + fourthNumber;
        }

        /// <summary>
        /// //равна ли сумма двух первых его цифр чсла сумме двух его последних цифр
        /// </summary>
        /// <param name="a">First value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsSumDivisibleByThree(int a)
        {
            if (a < 1000 || a > 9999)
            {
                throw new ArgumentException("Число должно быть четырёхзначным");
            }

            int firstNumber = a / 1000;
            int secondNumber = (a / 100) % 10;
            int thirdNumber = (a / 10) % 10;
            int fourthNumber = a % 10;
            int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;

            return sum % 3 == 0;
        }

        /// <summary>
        /// проверка: кратно ли произведение цифр введенному числу A 
        /// </summary>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsProductDivisibleByA(int a, int b)
        {
            if (a < 1000 || a > 9999)
            {
                throw new ArgumentException("Число должно быть четырёхзначным");
            }

            int firstNumber = a / 1000;
            int secondNumber = (a / 100) % 10;
            int thirdNumber = (a / 10) % 10;
            int fourthNumber = a % 10;

            int product = firstNumber * secondNumber * thirdNumber * fourthNumber;

            return product != 0 && product % b == 0;
        }
    }
}
