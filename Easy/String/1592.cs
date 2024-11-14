public class Solution
{
    public string ReorderSpaces(string text)
    {
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        int totalSpace = text.Count(c => c == ' ');

        if (wordCount == 1)
        {
            return words[0] + new string(' ', totalSpace);
        }

        int equalSpace = totalSpace / (wordCount - 1);
        int moreSpace = totalSpace % (wordCount - 1);
        string result = string.Join(new string(' ', equalSpace), words);
        result += new string(' ', moreSpace);

        return result;
    }
}