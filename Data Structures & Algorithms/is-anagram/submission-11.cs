public class Solution {
    public bool IsAnagram(string s, string t) {

     if(s.Length!=t.Length){
        return false;
     }
     Char[]c=s.ToCharArray();
     Char[]m=t.ToCharArray();
     Array.Sort(c);
     Array.Sort(m);
     for(int i =0 ; i< c.Length;i++){
        if(c[i]!=m[i]){
            return false;
        }
     }
    return true;
    }
}
