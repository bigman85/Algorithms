using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort
{
    public class BucketSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            int step = 10;
            if( arr.Length < 2){
                return;
            }
            var lst = Sort(new LinkedList<int>(arr), step);
            
            var t = lst.First;
            for(int i=0; i<arr.Length; i++,t=t.Next){
                arr[i] = t.Value;
            }

       }

       LinkedList<int> Sort(LinkedList<int> src, int step) {
           if( src.Count < 2 || step == 0){
               return src;
           }

            var res = new LinkedList<int>();
            int min = 0;
            int max = 0;

            var t = src.First;
            while( t != null) {
                min = min < t.Value?min:t.Value;
                max = max > t.Value?max:t.Value;
                t = t.Next;
            }

            var buckets = new LinkedList<int>[(max - min) / step +1];

            t = src.First;
            while( t != null) {
                if(buckets[(t.Value-min)/step]==null){
                    buckets[(t.Value-min)/step] = new LinkedList<int>();
                }
                buckets[(t.Value-min)/step].AddLast(t.Value);
                t = t.Next;
            }

            for(int i = 0; i < buckets.Length; i++) {
                if(buckets[i]==null || buckets[i].Count==0) continue;
                buckets[i] = Sort(buckets[i], step/2);
                var ts = buckets[i].First;
                while(ts != null){
                    res.AddLast(ts.Value);
                    ts = ts.Next;
                }
            }

           return res;
       }
    }
}
