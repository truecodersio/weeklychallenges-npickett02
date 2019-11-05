using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (var str in words)
            {
                if (str == null) continue;
                if (ignoreCase && word.ToLower() == str.ToLower())
                {
                    return true;
                }
                else if (!ignoreCase && word == str)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            else if (num % 2 == 0)
            {
                return num == 2;
            }
             
            int N = (int)(Math.Sqrt(num) + 0.5);

            for (int i = 3; i <= N; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
                    
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int lastUniqueIndex = -1;
            int counter = 0;
            var uniqueCharacters = GetUniqueCharacters(str);
            foreach (var c in str)
            {
                if (uniqueCharacters.Contains(c))
                {
                    lastUniqueIndex = counter;
                }
                counter++;
            }
            return lastUniqueIndex;
        }

        public List<char> GetUniqueCharacters(string str)
        {
            List<char> uniqueCharacters = new List<char>();
            foreach (char c in str)
            {
                if (IsCharacterUnique(str, c))
                {
                    uniqueCharacters.Add(c);
                }
            }
            return uniqueCharacters;
        }

        public bool IsCharacterUnique(string str, char c)
        {
            int charCounter = 0;
            foreach (char c_ in str)
            {
                if (c_ == c)
                {
                    charCounter++;
                }
            }
            if (charCounter > 1)
            {
                return false;
            }
            return true;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int previousNumber = numbers[0];
            int currentConsecutive = 1;
            int currentMaxConsecutive = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == previousNumber)
                {
                    currentConsecutive++;
                }
                if (currentConsecutive > currentMaxConsecutive)
                {
                    currentMaxConsecutive = currentConsecutive;
                }
                if (numbers[i] != previousNumber)
                {
                    currentConsecutive = 1;
                }
                previousNumber = numbers[i];
            }
            return currentMaxConsecutive;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 0) return new double[0];
            List<double> everyNthElement = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    everyNthElement.Add(elements[i - 1]);
                }
            }
            return everyNthElement.ToArray();
        }
    }
}
