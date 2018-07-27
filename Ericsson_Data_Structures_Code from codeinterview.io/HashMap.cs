//Hash Map
//https://codeinterview.io/UAHBYSVPSS
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    
    HashMap<string, string> keyvalue = new HashMap<string, string>();
    keyvalue.Add("suresh","suresh1");
     keyvalue.Add("suresh2","suresh3");
    
    Console.WriteLine (keyvalue["suresh"]);
    Console.WriteLine (keyvalue["suresh2"]);
    
  }
}

 public class HashMap<TKey, TVal>
    {
        HashMapNode<TKey,TVal>[] HashMapNode;
        int defaultLenght = 10;
        public HashMap()
        {
            HashMapNode = new HashMapNode<TKey, TVal>[defaultLenght];
        }

        public void Add(TKey key, TVal val)
        {

            HashMapNode<TKey, TVal> node = new HashMapNode<TKey, TVal>(key, val);
            int hashCode = Math.Abs(key.GetHashCode());
            int index = GetIndex(hashCode);


            if (HashMapNode[index] != null)
            {
                HashMapNode<TKey, TVal> hashTemp = HashMapNode[index];

                do
                {
                    if (hashTemp.hashCode == hashCode)
                    {
                        Console.WriteLine("Key is already exists");
                        return;
                    }
                    else