using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;

            if (remainder == 0)
            {
                return startNumber + n;
            }
            
            return startNumber + (n - remainder);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";
            bool isFirstWord = true;

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (isFirstWord)
                    {
                        sentence += word.Trim();
                        isFirstWord = false;
                    }
                    else
                    {
                        sentence += " " + word.Trim();
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(sentence))
            {
                return "";
            }

            return sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();
            for (int i = 3; i < elements.Count; i+= 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i  + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
