//Merge Arrays
//https://codeinterview.io/LHJQEUERMH
using System;

public class Test
{
  public static void Main()
  {
    Console.WriteLine("Hello");
    
    int [] array1= new int [] {2,4,6,8,50};
     int [] array2= new int [] {3,5,7,9,13,20,50};
    int [] mergeArray = MergeSortedArrays.Merge(array1,array2);
    
    Console.WriteLine(string.Join(",",mergeArray));
  }
}

public static class MergeSortedArrays
{
  public static int[] Merge(int[] array1,int[]array2)
  {
    int countArray1 = array1.Length;
    int countArray2 = array2.Length;
    int incrementArray1=0;
    int incrementArray2 =0;
    int [] mergeArray=new int[countArray1+countArray2];
    int countMergeArray=0;
    while(incrementArray1< countArray1 
          && incrementArray2<countArray2)
    {
      if (array1[incrementArray1]< array2[incrementArray2])
      {
        mergeArray[countMergeArray++]=array1[incrementArray1++];
      }
      else
      {
        mergeArray[countMergeArray++]=array2[incrementArray2++];
      }
    }
    
    
      while (incrementArray1<countArray1)
      {
         mergeArray[countMergeArray++] =array1[incrementArray1++];
      }
       
   
      while(incrementArray2<countArray2)
      {
         mergeArray[countMergeArray++]=array2[incrementArray2++];
      }
    
    
    return mergeArray;
  }
}
