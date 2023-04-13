namespace HelpingLibrary.Interpretator
{
    public class NumberInterpretator
    {
        /// <summary>
        /// Returns the letter version of the number 
        /// </summary>
        /// <param name="number">Number that is needed to be parsed in word variant</param>
        /// <returns>Returns the letter version of the number</returns>
        public static string GetWordInterpretation(int number)
        {
            var parsed = Helpers.GetListOfNumbers(number);

            var length = parsed.Count;
            var firstDigit = parsed.First();
            var unit = parsed.Last();

            switch (length)
            {
                case 1 when firstDigit == 0:
                    return DigitNames.Units[firstDigit];

                case 1:
                    return GetUnit(unit);

                case 2:
                    return GetTwoDigitNumber(unit, firstDigit);

                case 3:
                default:
                    return GetThreeDigitNumber(parsed, firstDigit);

            };
        }

        private static string GetThreeDigitNumber(List<int> parsed, int hundred)
        {
            return $"{DigitNames.Units[hundred]} hundred {GetTwoDigitNumber(parsed.Last(), parsed[^2])}";
        }

        private static string GetTwoDigitNumber(int unit, int dozen)
        {
            var unitName = DigitNames.Units[unit];

            if (dozen == 1)
            {
                if (unit <= 3 || unit == 8)
                    return DigitNames.FirstDozen[unit];

                return $"{unitName}teen";
            }

            var dozenName = dozen switch
            {
                2 or 3 or 8 => DigitNames.Dozens[dozen],
                _ => $"{DigitNames.Units[dozen]}ty"
            };

            if (unit == 0)
                return dozenName;

            return string.Join(" ", dozenName, unitName);
        }

        private static string GetUnit(int unit)
            => DigitNames.Units[unit];
    }
}
