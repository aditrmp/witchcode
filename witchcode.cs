using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Villager 1 age of death: ");
		int vAgeFirst = Convert.ToInt32(Console.ReadLine());
		Console.Write("Villager 1 year of death: ");
		int vYodFirst = Convert.ToInt32(Console.ReadLine());
		
        Console.Write("Villager 2 age of death: ");
		int vAgeSec = Convert.ToInt32(Console.ReadLine());
		Console.Write("Villager 2 year of death: ");
		int vYodSec = Convert.ToInt32(Console.ReadLine());
		
		double result =  Result.countAverage(vAgeFirst, vYodFirst, vAgeSec, vYodSec);//countAverage(vAgeFirst, vYearFirst, vAgeSec, vYearSec);
		Console.WriteLine("Average number of people killed is " + result);
	}
}

class Result{
	public static double countAverage(int vAgeFirst, int vYodFirst, int vAgeSec, int vYodSec){
		double result = 0;
		int totalVictims1 = 0;
		int totalVictims2 = 0;
		int yobFirst = vYodFirst-vAgeFirst;
		int yobSec = vYodSec-vAgeSec;
			
		if(yobFirst < 0 || yobSec < 0){
			result = -1;	
		} else{
			totalVictims1 = countPeopleKilled(yobFirst);
			totalVictims2 = countPeopleKilled(yobSec);
			result =  (totalVictims1+totalVictims2)/2;
			Console.WriteLine("korban1 "+countPeopleKilled(yobFirst));
			Console.WriteLine("korban2 "+countPeopleKilled(yobSec));
		}
			
		return result;
   	}
		
	public static int countPeopleKilled (int year){
		int num1 = 0;
		int num2 = 1;
		int num3 = 0;
		int result = 0;
		Console.WriteLine(year);
			
		if(year == 1){
			result = 1;
		} else if(year > 1){
			result = 1;
			for(int i=1; i<year; i++){
				num3 = num1 + num2;
				Console.Write(num3 + ", ");
				result += num3;
				num1 = num2;
				num2 = num3;
			}
		}
		return result;
	}
}
