public class Solution {
    public int LongestConsecutive(int[] nums) {
      if(nums.Length==0){
        return 0 ;
      }
      Array.Sort(nums);
      int res=1;
      int count=1;
      for(int i =1;i<nums.Length;i++){
        if(nums[i]-1==nums[i-1] ){
            count++;
        }else if( nums[i]==nums[i-1]){
            
        }
        else{
            if(res<count){
                res=count;
                count=1;
            }else{
                count=1;
            }

        }
      
      }
      if(res<count){
        res=count;
      }
      return res;

    }
}
