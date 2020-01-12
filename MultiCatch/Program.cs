using System;

namespace MultiCatch
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				throw new NotImplementedException();
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine($"DivideByZeroException: {ex.Message}");
			}
			catch (NotImplementedException ex)
			{
				Console.WriteLine($"NotImplementedException: {ex.Message}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception: {ex.Message}");
			}
		}

	}
}
