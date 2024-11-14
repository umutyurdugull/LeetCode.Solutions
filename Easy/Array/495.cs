public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        if(timeSeries == null || timeSeries.Length == 0)
        {
            return 0;
        }
        int totalPoisonedTime = 0;
        for(int i =0;i < timeSeries.Length  -1;i++)
        {
            totalPoisonedTime += Math.Min(duration,timeSeries[i+1] - timeSeries[i]);
        }
        totalPoisonedTime += duration;

        return totalPoisonedTime;

    }
}