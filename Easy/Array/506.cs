public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int len = score.Length;
        string[] result = new string[len];
        (int score,int index)[] scoreWithIndex = new (int,int)[len];
        for(int i = 0; i < len;i++)
        {
            scoreWithIndex[i] = (score[i],i);
        }
        Array.Sort(scoreWithIndex,(a,b) => b.score.CompareTo(a.score));
        for(int i=0;i<len;i++)
        {
            if(i==0)
            {
                result[scoreWithIndex[i].index] = "Gold Medal";
            }
            else if(i ==1)
            {
                result[scoreWithIndex[i].index] = "Silver Medal";
            }
            else if(i == 2)
            {
                result[scoreWithIndex[i].index] = "Bronze Medal";
            }
            else
            {
                result[scoreWithIndex[i].index] = (i+1).ToString();
            }
        }

            return result;
    }
}