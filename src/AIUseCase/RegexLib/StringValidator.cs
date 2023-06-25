using System.Text.RegularExpressions;

namespace RegexLib
{
    public class StringValidator
    {
        private const string SpecialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        public bool IsStringValid(string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input) || input.Length > maxLength)
                return false;

            string pattern = $"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[{SpecialCharacters}])[^\s]{{{maxLength}}}$";

            return Regex.IsMatch(input, pattern);
        }
    }
}