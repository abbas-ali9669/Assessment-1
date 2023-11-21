using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)

        {

            // QuestionOne.ReverseAndNot(123);
            // QuestionOne.ReverseAndNot(152);
            // QuestionOne.ReverseAndNot(123456789);

            // Console.WriteLine(QuestionTwo.LongestCommonEnding("passion", "ion"));
            // Console.WriteLine(QuestionTwo.LongestCommonEnding("multiplication", "ration"));
            // Console.WriteLine(QuestionTwo.LongestCommonEnding("skyscraper", "carnivore"));
            // Console.WriteLine(QuestionTwo.LongestCommonEnding("potent", "tent"));

            // QuestionThree.divisibleAndSum();

            // QuestionFour.maxOccur();

            QuestionFive.isPrime();

            Console.ReadLine();
        }
    }

    class QuestionOne
    {
        // Q 1: Write a function that takes an integer i and returns a string with the integer
        // backwards followed by the original integer.
        public static void ReverseAndNot(int i)
        {
            int duplicate = i;
            int reverse = 0;
            int reminder = 0;
            for (; i != 0;)
            {
                reminder = i % 10;
                reverse = reverse * 10 + reminder;
                i /= 10;
            }
            // Console.WriteLine(Convert.ToString(reverse)+Convert.ToString(duplicate));
            Console.WriteLine("Reversed: " + reverse + "\nOrignial: " + duplicate + "\n");
        }
    }

    class QuestionTwo
    {
        // Q: Write a function that returns the longest common ending between two strings.

        public static string LongestCommonEnding(string wordA, string wordB)
        {
            string commonWord;
            for (int i = 0; i <= wordA.Length; i++)
            {
                // commonWord =  wordA[i];
                commonWord = wordA.Substring(i);
                // Console.WriteLine(commonWord);
                if (wordB.EndsWith(Convert.ToString(commonWord)))
                {
                    return commonWord;
                }
            }
            return "";
            // Console.WriteLine(commonWord);
        }
    }

    class QuestionThree
    {
        public static void divisibleAndSum()
        {
            int total = 0;
            for (int i = 101; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }

    class QuestionFour
    {
        public static void maxOccur()
        {
            string str;
            int[] ch_fre = new int[255];
            int i = 0, max, l;
            int ascii;

            Console.Write("Input the string : ");

            str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 255; i++)
            {
                ch_fre[i] = 0;
            }

            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                ch_fre[ascii] += 1;

                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (ch_fre[i] > ch_fre[max])
                        max = i;
                }
            }
            //Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, ch_fre[max]);
            Console.Write($"{(char)max}, {ch_fre[max]}");
        }
    }

    class QuestionFive
    {
        public static void isPrime()
        {
            Console.Write("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());

            int nextPrime = 0;
            if (number <= 1)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Pow(number, 0.5); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        // int nextPrime = 0;
                        for (int j = 2; j < number; j++)
                        {
                            if (number % j == 0)
                            {
                                number++; j = 2;
                                nextPrime = number;
                            }
                        }
                        // Console.WriteLine(nextPrime);
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{number} number is Prime");
                }
                else
                {
                    Console.WriteLine("The number is not Prime");
                    Console.WriteLine($"The next Prime Number is {nextPrime}");
                }
            }
        }
    }
}
