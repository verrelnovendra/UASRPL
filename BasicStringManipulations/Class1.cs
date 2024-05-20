namespace BasicStringManipulations
{
    public class StringManipulator
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
