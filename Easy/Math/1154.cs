public class Solution
{
    public int DayOfYear(string date)
    { 
        DateTime parsedDate = DateTime.Parse(date);
        return parsedDate.DayOfYear;
    }


}