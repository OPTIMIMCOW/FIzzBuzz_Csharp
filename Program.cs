using System;
using System.Collections.Generic;

namespace FizzBuzz_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 22; i++)
            {
                List<string> returnValue = new List<string>();
                Boolean bangFlag = false;
                if (i % 7 == 0)
                {
                    bangFlag=true;
                    returnValue.Add("Bang");
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    returnValue.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    returnValue.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    returnValue.Add("Buzz");
                }
                else if (bangFlag != true)
                {
                    returnValue.Add(i.ToString());
                }

                if(i%11==0){
                    returnValue.Clear();
                    returnValue.Add("Bong");
                }

                returnValue.Reverse();
                String returnString = "";
                for (int j = 0; j < returnValue.Count; j++)
                {
                    returnString = returnString + returnValue[j];
                }
                Console.WriteLine(returnString);
            }
        }
    }
}
