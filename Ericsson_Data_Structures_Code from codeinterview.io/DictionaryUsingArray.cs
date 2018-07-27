//Dictionary using array
//https://codeinterview.io/DEADOSAJMP
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    DictionaryUsingArray<string,string> dictionary = new DictionaryUsingArray<string,string>();
   
    for(int i=0;i<20;i++)
    {
      dictionary.Add($"suresh{i}",$"suresh{i}");
    }
    dictionary.Add($"suresh1",$"suresh1");   
    
    dictionary.print();
    dictionary.Remove("suresh2");
    Console.WriteLine(dictionary.GetItem("suresh1"));
    dictionary.print();
  }
}

public class DictionaryUsingArray<Key,Val>
{
  private int _intialLenth=10;
  private int _counter=0;
  private int _currentLenght=10;
  private Key[] _key;
  private Val[] _val;
  
  
  
  public DictionaryUsingArray ()
  {
    _key = new Key[_intialLenth];
    _val= new Val[_intialLenth];
  }
  
  public void Add(Key key,Val val)
  {
    if(GetIndex(key)>=0)
    {
      return;
    }
    
    if(_counter==_currentLenght)
    {
      Resize();
    }
    
    _key[_counter]=key;
    _val[_counter++]=val;
  }
  
 public Val GetItem(Key key)
 {
    int index = GetIndex(key);
    if(index>=0)
    {
      return _val[index];
    }
    
    return default(Val);
 }
  public int Remove(Key key)
  {
    int index = GetIndex(key);
    if (index <=0)
    return index;   
    
    Array.Copy(_key,index+1,_key,index,(_counter-1)-index);
    Array.Copy(_val,index+1,_val,index,(_counter-1)-index);
    return index;
  }
  private void Resize()
  {
    
     Key[] tempKey=_key;
    Val[] tempVal = _val;
    _currentLenght +=_intialLenth;
    _key =new Key[_currentLenght];
    _val =new Val[_currentLenght];
    
    tempVal.CopyTo(_key,0);
    tempVal.CopyTo(_val,0);

  }
  
  private int GetIndex(Key key)
  {
    for (int i=0;i<_currentLenght;i++)
    {
      if(object.Equals(key,_key[i]))
        return i;
        
    }
    return -1;
  }
  
  public void print()
  {
    
    for (int i=0; i<_counter;i++)
    {
      Console.WriteLine($"Key {_key[i]} : Value {_val[i]}");
    }
  
  }
  
}
