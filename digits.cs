using System;
//COUNTERS DIGITS


class digits
{
    static void Main()
    {
  
        int oneDigit =0, twoDigits =0,threeDigits =0, moreDigits = 0;

        Console.Write("Insert a number: "); 
       
        string inputDigit = Console.ReadLine();
        try
        {
            while (inputDigit != "end")
            {
                int input = Convert.ToInt32(inputDigit);

                if (input != 0)
                {
                    if (input / 10 == 0)//1 Digit
                    {
                        oneDigit++;
                    }

                    else if (input / 100 == 0)//2 Digit
                    {
                        twoDigits++;
                    }

                    else if (input / 1000 == 0)//3 Digit
                    {
                        threeDigits++;
                    }

                    else
                        moreDigits++;
                }

                inputDigit = Console.ReadLine();

                Console.WriteLine("One Digit: {0}; Two Digit: {1}; Three Digit: {2}; More Digit: {3}", oneDigit, twoDigits, threeDigits, moreDigits);
            }
            
        }catch(Exception e)
        {
            Console.Write("Bye!");
        }

    }
}