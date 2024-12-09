using System;

public class MergeStringsAlternately
{
    public static void Main(string[] args)
    {
        string word1 = "abcd";
        string word2 = "pq";
        int i = 0, j = 0;
        string result = "";
        while(i < word1.Length && j < word2.Length)
        {
            result += word1[i++];
            result += word2[j++];
        }
        
        if(i<word1.Length)
        result += word1.Substring(i);

        if(j<word2.Length)
        result += word2.Substring(j);
    }
}