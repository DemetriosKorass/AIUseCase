using RegexLib;
using System;
using System.Collections.Generic;
namespace RegexLib
{
    public class StringValidatorTest
    {
        private readonly StringValidator _validator;
        private readonly Dictionary<string, bool> _testCases;

        public StringValidatorTest(StringValidator validator)
        {
            _validator = validator;

            _testCases = new Dictionary<string, bool>
            {
                // Too short input
                { "V1#", false },
                // Too long input
                { "V12345678901#", false },
                // Matching input length
                { "Valid1#345", true },
                // Missing uppercase
                { "valid1#345", false },
                // Missing lowercase
                { "VALID1#345", false },
                // Missing special character
                { "Valid12345", false },
                // Missing digit
                { "ValidOne#", false },
                // Excess whitespace characters at the beginning
                { " Valid1#345", false },
                // Excess whitespace characters in the middle
                { "Valid1 #345", false },
                // Excess whitespace characters at the end
                { "Valid1#345 ", false },
            };
        }

        public void RunTests()
        {
            foreach (var testCase in _testCases)
            {
                bool result = _validator.IsStringValid(testCase.Key, 10);
                Console.WriteLine($"Test '{testCase.Key}': {(result == testCase.Value ? "Passed" : "Failed")}");
            }
        }
    }
}