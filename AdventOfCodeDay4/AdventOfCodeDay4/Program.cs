using System;


namespace AdventOfCodeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            int LowerBound = 193651;
            string LowerBoundString = "";
            int UpperBound = 649729;
            int Count = 0;
            int NumPasswords = 0;
           
            Char[] DigitArray = new char[6];
            bool rule2 = false;
            bool rule1 = false;

            for (LowerBound = 193651; LowerBound <= UpperBound; LowerBound++)
            {
                LowerBoundString = Convert.ToString(LowerBound);
                Console.WriteLine(LowerBoundString);
                DigitArray = LowerBoundString.ToCharArray();

                for (Count = 0; Count < 5; Count++)
                {
                    if (Convert.ToInt32(DigitArray[Count]) == Convert.ToInt32(DigitArray[Count + 1]))
                    {
                        
                                 rule1 = true;
                                break;
                              
                      
                    }
                }
                for (Count = 0; Count < 5; Count++)
                {
                    if (Convert.ToInt32(DigitArray[Count]) <= Convert.ToInt32(DigitArray[Count + 1]))
                    {
                        rule2 = true;
                    }

                    else
                    {
                        rule2 = false;
                        break;
                    }
                }



                if (rule2 == true && rule1 == true)
                {
                    Console.WriteLine("rule 1 and 2 true");
                    NumPasswords = NumPasswords + 1;
                }
                else
                {
                    Console.WriteLine("rules 1 and 2 not true");
                }
                rule1 = false;
                rule2 = false;
            }

            Console.WriteLine("number of passwords is" + NumPasswords);
            Console.ReadLine();
        }
    }
}
