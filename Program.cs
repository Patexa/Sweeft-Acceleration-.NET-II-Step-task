using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Task 1
        public static bool sPalindrome(string text)
        {
            int size = text.Length;
            for(int i = 0; i < size/2; i++)
            {
                if(text[i] != text[size-i-1]) return false;
            }
            return true;
        }

        //Task 2
        public static int MinSplit(int amount)
        {
            int answer = 0;
            int[] coins = {50,20,10,5};
            int index = 0;

            while(amount != 1 && index < 4)
            {
                answer += amount / coins[index];
                amount = amount % coins[index];
                index += 1;
            }

            return answer+amount;
        }

        //Task 3
        public static int NotContains(int[] array)
        {
            int i;
            for(i = 0; i < array.Max(); i++)
            {
                if(!array.Contains(i) && i > 0) return i;
            }
            return i+1;
        }

        //Task 4
        public static bool IsProperly(string sequence)
        {
            int counter = 0;

            for(int i = 0; i < sequence.Length; i++)
            {
                if(sequence[i] == '(') counter++;

                else if(sequence[i] == ')')
                {
                    counter--;
                    if(counter < 0) return false;
                }
            }
            return counter == 0;
        }

        //Task 5
        public static int CountVariants(int stairCount)
        {
            if (stairCount == 0 || stairCount == 1) return stairCount;
            
            int[] ways = new int[stairCount + 1];
            ways[0] = 1;
            ways[1] = 1;
            
            for (int i = 2; i <= stairCount; i++) 
            {
                ways[i] = ways[i-1] + ways[i-2];
            }
            
            return ways[stairCount];
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(sPalindrome("qqqqqwawawqqqqq"));
            System.Console.WriteLine(MinSplit(2794));
            int[] array = {1,2,3,4,5,6,7,8,10,11,12,13,14,70};
            System.Console.WriteLine(NotContains(array));
            System.Console.WriteLine(IsProperly("(()()()()()()()()())"));
            System.Console.WriteLine(CountVariants(10));
        }
    }
}