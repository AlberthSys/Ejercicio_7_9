using System;
//COUNTERS DIGITS


class digits
{
    static void Main()
    {
  
        int oneDigit =0, twoDigits =0,threeDigits =0, moreDigits = 0;

        Console.Write("Insert a number: "); 
       
        string inputDigit = Console.ReadLine();

        while (inputDigit != "end")
        {
            int input = Convert.ToInt32(inputDigit);

            if (input != 0)
            {
                if (input / 10 == 0)//1Digit
                {
                    oneDigit++;
                }
                    
                else if (input / 100 == 0)//2Digit
                {
                    twoDigits++;
                }
                     
                else if (input / 1000 == 0)//3Digit
                {
                    threeDigits++;
                }
                    
                else
                    moreDigits++;
            }

            inputDigit = Console.ReadLine();
            
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreDigits);

    }
}