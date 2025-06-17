using System;
 
namespace Spaces
{
public class Count_spaces

{
 public static void Main(string[] args)

{ Console.WriteLine("enter a sentence");
string sentence = Console.ReadLine();

int count = 0;

for ( int i = 0; i < sentence.Length; i++)
{ 
 if (sentence[i]== ' ')
	{ count++;
		}



}

Console.WriteLine("number of spaces : " + count);



}

}
}