//Circular Queue using array
//https://codeinterview.io/QPFTOCFWXR
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    CircularQueueUsingArray<int> queue = new CircularQueueUsingArray<int>();
    
    for(int i=0;i<5;i++)
    {
      queue.Enqueue(i);
    }
    // queue.print();
   //queue.Dequeue();
   //  queue.print();
   // queue.Enqueue(11);
    
   //  queue.Dequeue();
   // queue.Enqueue(12);
    
    queue.print();
  }
}

public class CircularQueueUsingArray<T>
{
  T[] t;
  int front =0;
  int rare=0;
  int defaultSize=5;
  int count =0;
  public CircularQueueUsingArray()
  {
    t= new T[defaultSize];
  }
  
  public void Enqueue(T data)
  {
    
    if(count ==defaultSize )
    {
      Console.WriteLine("Queue is full");
      return;
    }
    
    if(rare==defaultSize)
    {
      rare=0;
    }
    if(front==defaultSize)
    {
      front=0;
    }
    
    t[rare++] =data;
    count++;
  }
  
  public  T Dequeue()
  {
    if(count==0)
    {
      Console.WriteLine("Queue is empty");
      return default(T);
    }
    count--;
    return t[front++];
    
  }
  
  public void print()
  {
      Console.WriteLine($"front:{front}");
      Console.WriteLine($"rare:{rare}");
     
     int index= front;
    
    for(int i=0; index<defaultSize && count>0; )
    {
      
    }
   
    if(front<rare)
    {
      for(int i=front; i<defaultSize;i++)
        {
          Console.WriteLine(t[i]);
        }
    }
    else {
      for(int i=front; i<defaultSize;i++)
        {
          Console.WriteLine(t[i]);
        }
        
     for(int i=0; i<rare;i++)
      {
        Console.WriteLine(t[i]);
      }
    }

   
  }
  
}
