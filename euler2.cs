using System;
using System.Collections.Generic;

public class majick{
	public static void Main(string[] args){
		List<int> fib = new List<int>();
		List<int> evens = new List<int>();
		int limit= 4000000;
		int iter = 1;
		int tempA= 1;
		int tempB= 2;
		int tempC=0;
		int result=0;
		fib.Add(tempA);
		fib.Add(tempB);
		while(iter<limit){
			tempC = tempA+tempB;
			tempA = tempB;
			tempB = tempC;
			fib.Add(tempC);
			iter=tempC;
		}
		foreach(int test in fib){
			if(test%2==0){
				evens.Add(test);
			}
			
		}
		foreach(int test in evens){
			result=result+test;
		}
		Console.WriteLine(result);
	}
}