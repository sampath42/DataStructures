//Number to word
//https://codeinterview.io/AMTCTHZSBS
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    Console.WriteLine(ConvertNumber.ConvertNumberToWord(12521126457347432));
  }
}

public static class ConvertNumber
{
  
  public static string ConvertNumberToWord(long number)
  {
    string word ="";
    
    if(number / 100000>0)
    {
      word += ConvertNumberToWord(number/100000) +" Lakhs";
      number%=100000;
    }
    if (number/10000>0)
    {
      word+=ConvertNumberToWord(number/1000) +" Thousand";
      number%=1000;
    }
    if (number/100>0)
    {
      word+=ConvertNumberToWord(number/100) +" Hundred";
      number%=100;
    }
    
    string[] Unit = new string []{"Zero","One","Two","Three","Four","Five","Six",
                                 "Seven", "Eight","Nine","Ten","Eleven","Tweleve","Thirteen"
                                 ,"Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
    string[] tens = new string []{"Zero","Ten","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eithty","Ninty","Hundered"};
  if(number>0){
    
    if(number<20) word+=" "+Unit[number];
    
    else {
      word+=" "+ tens[number/10];
      if(number%10>0){
        word+= " "+Unit[number%10];
      }
    }
    
  }
    return word;
  }
  
}
