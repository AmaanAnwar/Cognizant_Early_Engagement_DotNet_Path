using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals7			//DO NOT CHANGE the name of namespace
{
	public class Program			//DO NOT CHANGE the name of the class 'Program'
	{
		//Implement the code here
		Console.WriteLine("Enter the name of product :");
		string productName = Console.ReadLine();
		
		Console.WriteLine("Enter the price of the product :");
		int price = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Is the product on SALE (yes/no) :");
		string onSale = Console.ReadLine();
		
		Console.WriteLine("Enter number of product sold in day 1");
		int day1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter number of product sold in day 2");
		int day2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter number of product sold in day 3");
		int day3 = int.Parse(Console.ReadLine());
		
		Console.WriteLine(productName);
		
		if (onSale == "yes")
		{
			Console.WriteLine($"Day 1 sales total : {(day1*price*0.93)};
			Console.WriteLine($"Day 2 sales total : {(day2*price*0.93*0.93)};
			Console.WriteLine($"Day 3 sales total : {(day3*price*0.93*0.93*0.93)};
		}
		else if (onSale == "no")
		{
			Console.WriteLine($"Day 1 sales total : {(day1*price)};
			Console.WriteLine($"Day 2 sales total : {(day2*price)};
			Console.WriteLine($"Day 3 sales total : {(day3*price)};
		}
	}
}
