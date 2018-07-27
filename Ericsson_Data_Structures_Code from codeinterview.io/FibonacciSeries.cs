//Fibonacci Series
//https://codeinterview.io/OMGLGQDNSX
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    FibonacciSerice serice = new FibonacciSerice();
    Console.WriteLine( serice.Fibonacci(15) );
     Console.WriteLine( serice.DinamicFab(15) );
    
  }
}

public class FibonacciSerice
{
  public int Fibonacci(int n)
  {
    if(n<=1)
      return n;
    
    return Fibonacci(n-1) + Fibonacci(n-2);
    
  }
  
  public int DinamicFab(int n)
  {
    int [] f= new int [n+2];
    
    f[0]=0;
    f[1]=1;
    
    for (int i=2; i<=n;i++)
    {
      f[i] = f[i-1]+f[i-2];  
    }
    
    return f[n];
  }
}
