using System;

namespace LibraryForLesson3
{
    public class LibraryForHWLesson3
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Power(int a, int b)
        {
            int result = a;

            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }

            return result;
        }

        public static int Divider(int inputNumberA, int lastCheckNumber)
        {
            int result = 0;
            for (int i = inputNumberA; i <= lastCheckNumber; i += inputNumberA)
            {
                if (i % inputNumberA == 0)
                {
                    result = i;
                }
            }

            return result;
        }

        public static int InputNumberInSquereByA(int inputNumber, int powerSquare)
        {
            int count = 0;

            for (int i = 0; i <= inputNumber; i++)
            {
                if (inputNumber > LibraryForHWLesson3.Power(i, powerSquare))
                {
                    count++;
                }
            }

            return count;
        }

        public static int MaxDividerByA(int inputNumber)
        {
            for (int i = inputNumber - 1; i < inputNumber; i--)
            {
                if (inputNumber % i == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int SumNumberForRengeAtoB(int inputNumberA, int inputNumberB)
        {
            int sum = 0;
            if (inputNumberB < inputNumberA)
            {
                LibraryForHWLesson3.Swap(ref inputNumberA, ref inputNumberB);
            }

            for (int i = inputNumberA; i < inputNumberB; i++)
            {
                sum += i;
            }
            return sum;

        }

        public static int Fibonachi(int maxRange)
        {
            int inputNumberA = 1;
            int inputNumberB = 1;
            for (; maxRange > 2; maxRange -= 2)
            {
                inputNumberA += inputNumberB;
                inputNumberB += inputNumberA;
            }

            return maxRange == 1 ? inputNumberA : inputNumberB;
        }

        public static int CommonDivisorForAbyB(int numberA, int numberB)
        {
            if (numberA == 0)
            {
                return numberB;
            }
            else
            {
                while (numberB != 0)
                {
                    if(numberA > numberB)
                    {
                        numberA -= numberB;
                    }
                    else
                    {
                        numberB -= numberA;
                    }
                }
            }

            return numberA;
        }

    }
}
