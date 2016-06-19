using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1_Rebuild_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int digit = 0;
            int rndNumber;
            int minNumber= 2147483647;
            Random rnd = new Random();

            do
            {
                rndNumber = rnd.Next(1,100);
                myArray[digit] = rndNumber;
                if (myArray[digit]<minNumber)
                {
                    minNumber = myArray[digit];
                }
                Console.WriteLine(myArray[digit]);
                digit++;
            } while (myArray.Length>digit);

            Console.WriteLine("\nMin number is: " + minNumber);
            Console.ReadLine();
        }
    }
}
