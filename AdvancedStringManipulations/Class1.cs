namespace AdvancedStringManipulations
{
    public class StringManipulator
    {
        public int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
