public class Solution {
    public string GdcOfStrings(string str1, string str2)
    {
        if(str1+str2 != str2+str1)
        return "";

        int gcdLength = Gdc( str1.Length, str2.Length);
        return str1.Substring(0, gcdLength); 
    }
    
    public string Gdc(int a,int b)
    {
        return b==0 ? a : Gdc( b , a % b);
    }
}