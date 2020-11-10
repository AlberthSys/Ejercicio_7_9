
using System;

//CALCULATE THE AVAREGE

public class Average
{
	public static void Main()
	{
		double fisrtnumber = 0, anotherNumber, counting = 0, totalAverage;
		string input_console;

		Console.Write("Insert a mark: ");
		input_console = Console.ReadLine(); // Check Condition

        try
        {

			while (input_console != "end")
			{
				anotherNumber = Convert.ToDouble(input_console);

				counting++;   //counter of numbers

				fisrtnumber += anotherNumber;  // sum of all the notes

				Console.Write("Insert a mark: ");
				input_console = Console.ReadLine();
			}

			if (counting != 0)
			{
				totalAverage = fisrtnumber / counting;
				Console.WriteLine("The average is {0}.", totalAverage);
			}

			else if (input_console=="end")
			{
				Console.WriteLine("Bye!");
			}

		}catch (Exception e)
		{
			Console.WriteLine("Need one numeber please");
		}
	}
}