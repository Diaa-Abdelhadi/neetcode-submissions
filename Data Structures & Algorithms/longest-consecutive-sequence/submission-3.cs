public class Solution {
    public int LongestConsecutive(int[] nums) {
    HashSet<int>res=new HashSet<int>(nums);
    int longest=0;
    foreach(int num in res){
        if(!res.Contains(num-1)){
            int l =1;
            int next=num;
            while(res.Contains(next+1)){
                l++;
                next++;
            }
            if(longest<l){
                longest=l;
            }
        }

    }
    return longest;
    }
}
