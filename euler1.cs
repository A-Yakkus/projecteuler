using System;
using System.Collections.Generic;

public class magic
{
	public static void Main(String[] args)
	{
		List<int> mo3 = new List<int>();
		List<int> mo5 = new List<int>();
		List<int> comb = new List<int>();
		int limit = 1000;
		int iter = 0;
		int result=0;
		while(iter<limit){
			iter=iter+3;
			if(iter%5!=0)
				mo3.Add(iter);
		}
		iter=0;
		while(iter<limit){
			iter=iter+5;
			//if(iter%3!=0)
				mo5.Add(iter);
		}
		
		Console.WriteLine(mo3.Count);
		Console.WriteLine(mo5.Count);
		
		foreach(int t in mo3){
			comb.Add(t);
		}

		foreach(int t in mo5){
			comb.Add(t);
		}		
		
		comb.Sort();
		
		foreach(int t in comb){
			result=result+t;
		}
		Console.WriteLine(result);
	}
}