
using System;

//CALCULATE THE AVAREGE

public class Average
{
	public static void Main()
	{
		double fisrtnumber = 0, b, countingNumbersInput = 0, totalAverage;
		string input_console;

		Console.Write("Insert a mark: ");
		input_console = Console.ReadLine();

        try
        {
		while (input_console != "end")
		{  
			b = Convert.ToDouble(input_console);

			countingNumbersInput++; 

			fisrtnumber += b; 

			Console.Write("Insert a mark: ");
			input_console = Console.ReadLine();
		}

		if (countingNumbersInput != 0)
		{
			totalAverage = fisrtnumber / countingNumbersInput;
			Console.WriteLine("The average is {0}.", totalAverage);
		}
		
		else if (input_console=="end")
		{
			Console.WriteLine("Bye!");
		}
		
	}catch (Exception e)
	{
		Console.WriteLine("Need one number please");
	}
	}
}
