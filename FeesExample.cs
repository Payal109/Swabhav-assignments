using System;

namespace FeesExample

{
public class Example
{
	public static void Main(string[] args)
	{ double[] fees = new double[5];
	  double[] feesNow = new double[5];
		
		for (int i = 0; i < 5; i++)
		{ 	Console.Write("enter the fees of student {0} " , i+1);
			fees[i]= double.Parse(Console.ReadLine());
			if (fees[i] < 5000 || fees[i] > 10000)
					{Console.WriteLine("error : enter valid fees value");
						i--;
						}
			}
		feesNow = Process_fees(fees);		
		
	
		Console.WriteLine("The discounted fees are  ");
		
		for ( int i = 0; i < 5 ; i++)
			{ Console.WriteLine(" student {0} : {1}",i+1,feesNow[i]);

				}
}

	public static double[] Process_fees(double[] fees)
	{	
		double[] discountedFees = new double[5];
		for (int i = 0; i < 5; i++)
			{ 
				if (fees[i] > 7000 )
				{
					discountedFees[i]= fees[i] - fees[i] * 0.05;
					}
				else
           			 {	
                			discountedFees[i] = fees[i]; // no discount
            			}
			}
			
			return discountedFees;
		}
	
}


}