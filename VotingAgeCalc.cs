using System;
using System.Collections.Generic;

public class VotingAgeCalc
{
    public int LegalAge= 18;// avoiding magic number
    public string Name {  get; set; }
	public int Age { get; set; }

	public VotingAgeCalc(string name, int age)
		{ this.Age = age;
		  this.Name = name;
	}

	public void Eligibilitycheck()
	{
		if (this.Age >= LegalAge)

		{
			Console.WriteLine($" {this.Name}, You are Eligibile to vote");
		}

		else
		{
			Console.WriteLine($"{this.Name}, you are not eligible to vote");
		}
	}

	public static void Main(string[] args)
	{
		Console.WriteLine("enter your name ");
		string first = Console.ReadLine();
		VotingAgeCalc obj1 = new VotingAgeCalc(first, 23);
		obj1.Eligibilitycheck();

        Console.WriteLine("enter your name ");
        string second = Console.ReadLine();
        VotingAgeCalc obj2 = new VotingAgeCalc(second, 14);
        obj2.Eligibilitycheck();



    }

	
}

