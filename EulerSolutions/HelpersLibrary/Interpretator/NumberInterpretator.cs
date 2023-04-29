namespace HelpersLibrary.Interpretator
{
    public class NumberInterpretator
    {
        /// <summary>
        /// Provide the letter version of the number which is less than 10000
        /// </summary>
        /// <param name="number">Number that is needed to be parsed in word variant</param>
        /// <returns>Returns the letter version of the number</returns>
        public static string GetWordInterpretation(int number)
        {
            var parsed = Helpers.GetListOfDigits(number);

            var length = parsed.Count;
            var firstDigit = parsed.First();
            var unit = parsed.Last();

            string result;

            switch (length)
            {
                case 1 when firstDigit == 0:
                    result = DigitNames.Units[firstDigit];
                    break;

                case 1:
                    result = GetUnit(unit);
                    break;

                case 2:
                    result = GetTwoDigitNumber(unit, firstDigit);
                    break;

                case 3:
                    result = GetThreeDigitNumber(parsed, firstDigit);
                    break;

                case 4:
                    result = GetFourDigitNumber(parsed, firstDigit);
                    break;

                default:
                    return "This number is too big for this method";
            };

            return result.Replace("  ", " ");
        }

        private static string GetFourDigitNumber(List<int> parsed, int thousand)
        {
            return $"{DigitNames.Units[thousand]} thousand {GetThreeDigitNumber(parsed, parsed[^3])}";
        }

        private static string GetThreeDigitNumber(List<int> parsed, int hundred)
        {
            var hundredName = DigitNames.Units[hundred];
            var unit = parsed.Last();
            var dozen = parsed[^2];

            var hundredString = hundred == 0
                ? string.Empty
                : $"{hundredName} hundred";

            if (unit == 0 && dozen == 0)
                return hundredString;

            if (dozen == 0)
                return $"{hundredString} and {GetUnit(unit)}";

            return $"{hundredString} and {GetTwoDigitNumber(unit, dozen)}";
        }

        private static string GetTwoDigitNumber(int unit, int dozen)
        {
            var unitName = DigitNames.Units[unit];

            if (dozen == 1)
            {
                if (unit is <= 3 or 5 or 8)
                    return DigitNames.FirstDozen[unit];

                return $"{unitName}teen";
            }

            var dozenName = dozen switch
            {
                <= 5 or 8 => DigitNames.Dozens[dozen],
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
