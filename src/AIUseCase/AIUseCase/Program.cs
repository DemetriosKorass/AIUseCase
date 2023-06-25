using RegexLib;

internal class Program
{
    private static void Main(string[] args)
    {
        var validator = new StringValidator();
        var validatorTest = new StringValidatorTest(validator);

        validatorTest.RunTests();
    }
}