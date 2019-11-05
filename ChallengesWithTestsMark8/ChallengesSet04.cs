using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }

                else if (numbers[i] % 2 != 0)
                {
                    result -= numbers[i];
                }

            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            list.Sort();

            return list[0];

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            list.Sort();

            return list[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 >sideLength1))
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            
            return double.TryParse(input, out _);


            /*double i = 0;
            bool result = double.TryParse(input, out i);
            return result;*/

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            var majority = (objs.Length / 2) + 1;
            var count = 0;

            foreach(var item in objs)
            {
                if (item == null)
                {
                    count++;
                }
            }
            if(count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {
            double result = 0;
            double counter = 0;
            
            if (numbers == null)
            {
                return result;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if ( numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                    counter++;
                }
            }
            if (result == 0)
            {
                return 0;
            }

            double average = result / counter;

            return average;
        /*  double sum = 0;
            double count = 0;

            if (number == null)
            {
                return 0;
            }

            foreach( var num in numbers)
            {
                if(num %  2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if( count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            } */


        }

        public int Factorial(int number)
        {
            var fact = 1;

            if( number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;


            /*
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int i, fact = 1;

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            if (i == 0)
            {
                return 1;
            }
            return fact; */


        }
    }
}
