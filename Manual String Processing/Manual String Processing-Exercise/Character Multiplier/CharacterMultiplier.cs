using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var str1 = input[0].ToCharArray();
            var str2 = input[1].ToCharArray();
            var minLength = Math.Min(str1.Length, str2.Length);
            BigInteger totalSum = 0;

            for (int i = 0; i < minLength; i++)
            {
                BigInteger currentMultiplier = str1[i] * str2[i];
                totalSum += currentMultiplier;
            }

            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    totalSum += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    totalSum += str2[i];
                }
            }

            Console.WriteLine(totalSum);

        }
    }
}
