﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }

            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                

            }
            return true;
           
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 || words.Length == 1)
            {
                return "";
            }
            string sentence = "";
            int counter = 0;
            foreach (string str in words)
            {
                if (str == " " || str == "")
                {
                    counter++;
                    continue;
                }

                string toAdd = str.Replace(" ", "");
                sentence += toAdd;

                if (counter < words.Length - 1 && toAdd != "") sentence += " ";
                else if (counter == words.Length - 1) sentence += ".";

                counter++;
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> everyFourth = new List<double>();
            double[] empty = new double[0];

            if (elements == null)
            {
                return empty;
            }
            for (int i = 3; i < elements.Count; i +=4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
