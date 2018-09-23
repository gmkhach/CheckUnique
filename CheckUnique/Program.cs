using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string of characters\n\n>>> ");
            string input = Console.ReadLine();
            int len = input.Length;
            char[] array = input.ToCharArray();
            bool unique = true;
            for (int i = 0; i < len -1; i++)
            {
                for(int j = i + 1; j < len; j++)
                {
                    if(array[i] == array[j])
                    {
                        unique = false;
                        break;
                    }
                }
            }
            if (unique)
            {
                Console.WriteLine("\nAll characters in the string are unique.");
            }
            else
            {
                Console.WriteLine("\nThe string contains doubles.");
            }
        }
    }
}
