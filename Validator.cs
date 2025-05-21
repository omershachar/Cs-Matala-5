namespace Assignment5.Utils
{
    public static class Validator
    {
        public static bool IsStringValid(string str)
            => !string.IsNullOrWhiteSpace(str) && str.All(char.IsLetter);

        public static bool IsNumberValid(string num)
            => !string.IsNullOrWhiteSpace(num) && num.All(char.IsDigit);

        public static bool IsDateValid(DateTime date)
            => date.Year > 1900 && date.Year < DateTime.Now.Year;

        public static bool IsColorCodeValid(string code)
        {
            if (string.IsNullOrWhiteSpace(code) || code.Length != 7 || code[0] != '#') return false;
            return code.Skip(1).All(c => char.IsDigit(c) || (c >= 'A' && c <= 'F'));
        }
    }
}
