//Stacks using Arrays
//https://codeinterview.io/AITCXMFJRM
using System;

public class Test
{
  public static void Main()
  {    
    CustomStack<string> customStack = new CustomStack<string>();
    customStack.Push("First");
    customStack.Push("Second");    
    customStack.Push("Third");  
    customStack.Push("Fourth");
    customStack.ShowStackItems(); 
    Console.WriteLine("Pop -> "+customStack.Pop());
    customStack.ShowStackItems(); 
  }
}

public class CustomStack<T>
{
  
  int size = 2;  
  int stackIndex = 0;
  T[] _stackData;
  
  public CustomStack()
  {
    _stackData = new T[size];
  }
  
  public void Push(T data)
  {
    if(stackIndex==size)
    {
      IncreaseSize();
    }
    _stackData[stackIndex]=data;
    stackIndex++;
  }
  
  public T Pop()
  {
    stackIndex--;
    T returnVal = _stackData[stackIndex];
    _stackData[stackIndex]=default(T);  
    return returnVal;
  }
  
  public void ShowStackItems()
  {
    foreach(T item in _stackData)
    {
      Console.WriteLine(item);
    }
  }
  
  private void IncreaseSize()
  {    
    T[] tempStackData =_stackData;    
    size += stackIndex;
    _stackData = new T[size];      
    tempStackData.CopyTo(_stackData,0);    
  }
}

