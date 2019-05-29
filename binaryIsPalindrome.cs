using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            string binary = "";
            while (input > 1)
            {
                binary = (input % 2) + binary;
                input = input / 2;
            }

            binary += input;
            Console.WriteLine(binary);

            bool binaryFlag = true;
            for (int i = 0; i < binary.Length / 2; i++)
            {
                if (binary[i] != binary[(binary.Length - 1 - i)])
                {
                    Console.WriteLine("It's binary is not a Palindrone");
                    binaryFlag = false;
                    break;
                }
            }
            if(binaryFlag)
                Console.WriteLine("It's binary is a Palindrone");
            Console.ReadLine();
        }
    }
}
