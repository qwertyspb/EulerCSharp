namespace HelpingLibrary.Interpretator
{
    public class DigitNames
    {
        public static Dictionary<int, string> Units => new()
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" }
        };

        public static Dictionary<int, string> FirstDozen => new()
        {
            { 0, "ten" },
            { 1, "eleven" },
            { 2, "twelve" },
            { 3, "thirteen" },
            { 8, "eighteen" }
        };

        public static Dictionary<int, string> Dozens => new()
        {
            { 2, "twenty" },
            { 3, "thirty" },
            { 8, "eighty" }
        };
    }
}
