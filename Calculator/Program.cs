CalculatorApp();
void CalculatorApp()
{
	try
	{
		// prompt user to enter first number
		Console.Write("Enter first number");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		//enter second number
		Console.Write("Enter second number");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		//enter operation
		Console.Write("Enter operator ( +,-,*,/) ");
		char operation = Convert.ToChar(Console.ReadLine());
		int result = 0;

		//perform the operation
		switch (operation)
		{
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;

        }
		Console.WriteLine("Result is: " + result);
	}
	catch (FormatException ex)
	{

		Console.WriteLine($"Error:{ex.Message}.Please enter a valid operation.");
	}
	finally
	{
		Console.WriteLine("Operation complete.");

	}


}

