using System;
using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Program
    {


        static void Main(string[] args)
        {
            List<int> correctNumbers = new List<int>();
            int sum = 0;
            LoopforSetNumber(ref correctNumbers);
            foreach (int i in correctNumbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        private static void LoopforSetNumber(ref List<int> myList)
        {

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    myList.Add(i);
                }
                if (!myList.Contains(i))
                {
                    if (i % 5 == 0)
                    {
                        myList.Add(i);
                    }
                }
            }
        }
    }

}
