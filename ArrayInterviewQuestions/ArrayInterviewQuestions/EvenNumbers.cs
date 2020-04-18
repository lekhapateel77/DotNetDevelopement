using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayInterviewQuestions
{
    public class EvenNumbers
    {


        public void printEvenNumber(int Number)
        {

            int count = 0;
            int i = 1;
            while (count < Number)
            {             
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                    count = count + 1;
                }
                i++;
            }
        }

        public void AnotherprintEvenNumber(int Number)
        {
            int k = 0;
            for(int i = 1; i < Number; i++)
            {
                k = k + 2;
                Console.WriteLine("{0}", k);
            }
        }
    }
}
