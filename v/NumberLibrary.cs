using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace NumberLibrary
{
    public static class NumberAnalyzer
    {
        //равна ли сумма двух первых его цифр сумме двух его последних цифр
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

        //кратна ли трём сумма его цифр;
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

        //кратно ли произведение его цифр введенному числу A 
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
