//StringExamples
//https://codeinterview.io/JUWDXIMNMP
using System;
using System.Collections;
public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    //Console.WriteLine( Palindrome.MaxPalindromes("aaddcf"));
    Palindrome.MaxPalindromes("aaba");
  }
}

public static class Palindrome
{
  public static bool IsPalindrome(string text)
  {
    int startIndex=0;
    int endIndex = text.Length-1;
    
    while (startIndex<endIndex)
    {
      if(text[startIndex++]!=text[endIndex--])
        return false;
    }
    
    return true;
  }
  
  public static bool IsRotationalPalindrome(string text)
  {
     string s1 ="";
    string s2 ="";
    
    if(IsPalindrome(text)) return true;
    
    int len = text.Length-1;
    int startIndex=0;
    int endIndex=len;
    
    while(startIndex<len)
    {
      s1 = text.Substring(startIndex,len-startIndex);
      s2 = text.Substring(0,startIndex++);
      
      if(IsPalindrome(s2+s1)) return true;
      
      
    }
    
    return false;
          
      
  }
  
  public static bool checkRearrangedPalindrome(string text)
  {
    
    int [] array = new int[256];
    int oddCount=0;
    foreach(char c in text)
    {
      array[(int)c]++;
    }
    
    for (int i =0; i<256; i++)
    {
     if((array[i] & 1) ==1)
     {
       oddCount++;
     } 
      
      if(oddCount>1)
        return false;      
      
    }
    return true;
  }
  
  public static void MaxPalindromes(string text)
  {
   // ArrayList arrayList = new ArrayList();
    string str="";
    for(int i=0;i<text.Length;i++)
    {
      FindPalindroms(i,i,text,ref str);
      //Console.WriteLine($"=================");
      FindPalindroms(i,i+1,text,ref str);
    }
    
    //Console.WriteLine(string.Join(",",arrayList.ToArray()));
    Console.WriteLine(str);
  }
  
  private static void FindPalindroms (int startIndex, int endIndex,
                                      string text,ref string str)
  {
    
    while (startIndex>=0 
          && endIndex < text.Length
          && text[startIndex]== text[endIndex])
    {   
       str += " " + text.Substring(startIndex,(endIndex-startIndex)+1);
     // Console.WriteLine($"startIndex:{startIndex}");
    //Console.WriteLine($"endIndex:{endIndex}");
    startIndex--;
    endIndex++;
    }
      
  }
  
  
}
