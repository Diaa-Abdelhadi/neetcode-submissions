public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       Dictionary<int,int> res = new Dictionary<int, int>();
       foreach(int num in nums){
        res[num]=res.GetValueOrDefault(num,0)+1;
       }
        List<int>[] b=new List<int>[nums.Length+1] ;
    for(int i =0; i<b.Length;i++){
        b[i]=new List<int>();

    }


      
       foreach(var r in res){
        int number = r.Key;
        int f=r.Value;
        b[f].Add(number);

        

       }

       List<int> result = new List<int>();
       for (int i= b.Length-1;i>=0 && result.Count<k;i--){
        foreach(int number in b[i]){
            result.Add(number);
            if(result.Count==k){
                break;
            }
        }

       }
       return result.ToArray();
    }
}
