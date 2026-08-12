public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length-1;
        bool flag=true;
        if(s.Length==1){
            return true;
        }

        while(start<=end){
            if(!Char.IsLetterOrDigit(s[start])){
                start++;
                continue;
            }
            if(!Char.IsLetterOrDigit(s[end])){
                end--;
                continue;
            }

            if(Char.ToLower(s[start])==Char.ToLower(s[end])){
                flag=true;
                
                
            }
              if(Char.ToLower(s[start])!=Char.ToLower(s[end])){
                flag=false;
                break;
                
            }
           
            start++;
            end--;
        }
        return flag;
        
    }
}
