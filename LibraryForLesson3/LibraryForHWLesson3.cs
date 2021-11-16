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

        public static int Power(int numberA, int degree)
        {
            int result = numberA;

            for (int i = 1; i < degree; i++)
            {
                result *= numberA;
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
                    if (numberA > numberB)
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

        public static int CubeRoot(int numberA)
        {
            int prevRoot = 0;
            int result = 0;

            int currentRoot = numberA / 2;
            for (int i = 0; i < 20; i++)
            {
                int cubeRoot = LibraryForHWLesson3.Power(currentRoot, 3);
                if (cubeRoot == numberA)
                {
                    result = currentRoot;
                    break;
                }
                else if (cubeRoot > numberA)
                {
                    prevRoot = currentRoot;
                    currentRoot /= 2;
                }
                else if (cubeRoot < numberA)
                {
                    currentRoot = (prevRoot + currentRoot) / 2;
                }
            }

            return result;
        }

        public static int OddNumbersByNumberA(int numberA)
        {
            int count = 0;

            for (int i = 1; i <= numberA; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static bool DifferenceSumEvenAndOddNumbers(int numberA)
        {
            int sumOddNumbers = 0;
            int sumEvenNumbers = 0;

            for (int i = 1; i <= numberA; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddNumbers += i;
                }
                else
                {
                    sumEvenNumbers += i;
                }
            }

            return sumEvenNumbers > sumOddNumbers ? true : false;
        }

        public static int ReverseInt(int numberA)
        {
            int result = 0;

            while (numberA > 0)
            {
                result = result * 10 + numberA % 10;
                numberA /= 10;
            }

            return result;
        }

        public static bool FindNumberAbyB(int numberA, int numberB)
        {
            int result = 0;

            string tempStrA = Convert.ToString(numberA);
            string tempStrB = Convert.ToString(numberB);
            for (int i = 0; i < tempStrB.Length - 1; i++)
            {
                if (tempStrB.IndexOf(tempStrA) != -1)
                {
                    result = tempStrB.IndexOf(tempStrA);
                    break;
                }
                else
                {
                    result = tempStrB.IndexOf(tempStrA);
                }
            }

            return result == -1 ? false : true;
        }
    }
}
