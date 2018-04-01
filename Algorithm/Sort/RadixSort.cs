using System;
using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class RadixSort : SortBase
    {
        const int radix = 10;

        public override void Sort(int[] arr)
        {
            int maxLength = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxLength = maxLength > arr[i].ToString().Length? maxLength:arr[i].ToString().Length;
            }

            var lst = new LinkedList<int>(arr);
            
            for (int i=0; i< maxLength; i++){

            lst = Sort(lst,i);

            }

             var t = lst.First;
            for(int i=0; i<arr.Length; i++,t=t.Next){
                arr[i] = t.Value;
            }

        }

       LinkedList<int> Sort(LinkedList<int> src, int d){
           var res = new LinkedList<int>();
           var head = new LinkedList<int>();
           var buckets = new LinkedList<int>[10];

           for (int i = 0; i < 10; i++)
           {
               buckets[i] = new LinkedList<int>();
           }

           int baseNum = (int)System.Math.Pow(10,d);

            var n = src.First;
            while (n != null)
            {
                if(n.Value < baseNum){
                    head.AddLast(n.Value);
                }
                else
                {
                    int t = n.Value%(10*baseNum)/baseNum;
                    buckets[t].AddLast(n.Value);
                }
                n = n.Next;
            }

           if(head.Count > 0){
               for(var t = head.First;t!=null;t=t.Next){
                   res.AddLast(t.Value);
               }
            }
           for (int i = 0; i < 10; i++)
           {
               if(buckets[i].Count > 0){
                   for(var t = buckets[i].First;t!=null;t=t.Next){
                       res.AddLast(t.Value);
                   }
               }
           }
           
           return res;
       } 

    }
}