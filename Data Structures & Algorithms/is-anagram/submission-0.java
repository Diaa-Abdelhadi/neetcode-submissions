class Solution {
    public boolean isAnagram(String s, String t) {
        if(s.length()!=t.length()){
            return false;

        }
        char[] F = s.toCharArray();
        char[] S = t.toCharArray();
        Arrays.sort(F);
        Arrays.sort(S);
       
        
        return Arrays.equals(F, S);
     
    }
}
