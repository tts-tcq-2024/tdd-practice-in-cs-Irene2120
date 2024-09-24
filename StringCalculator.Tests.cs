using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;


/*public class StringCalculatorAddTests
{
    [Fact]
    public void ExpectZeroForEmptyInput()
    {
        int expectedResult = 0;
        string input = "";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

  [Fact]
    public void ExpectZeroForSingleZero()
    {
        int expectedResult = 0;
        string input = "0";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

        Assert.Equal(expectedResult, result);
    }

  [Fact]
    public void ExpectSumForTwoNumbers()
    {
        int expectedResult = 3;
        string input = "1,2";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ExpectExceptionForNegativeNumbers()
    {
        Assert.Throws<Exception>(() =>
        {
            string input = "-1,2";
            StringCalculator objUnderTest = new StringCalculator();
            objUnderTest.Add(input);
        });
    }

  [Fact]
    public void ExpectSumWithNewlineDelimiter()
    {
        int expectedResult = 6;
        string input = "1\n2,3";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

  [Fact]
    public void IgnoreNumbersGreaterThan1000()
    {
        int expectedResult = 1;
        string input = "1,1001";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ExpectSumWithCustomDelimiter()
    {
        int expectedResult = 3;
        string input = "//;\n1;2";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }
}*/
public class StringCalculator
{
    [Fact]
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        string input = numbers;
        string delimiter = ExtractDelimiter(ref input);

        string inputs = ReplaceNewlines(input, delimiter);
        List<int> nums = ExtractNumbers(inputs, delimiter);

        CheckForNegatives(nums);
        return SumValidNumbers(nums);
    }
    [Fact]
    private string ExtractDelimiter(ref string numbers)
    {
        if (numbers.StartsWith("//"))
        {
            int delimiterEndPos = numbers.IndexOf('\n');
            string delimiter = numbers.Substring(2, delimiterEndPos - 2);
            numbers = numbers.Substring(delimiterEndPos + 1);
            return delimiter;
        }
        return ","; // Default delimiter
    }
     [Fact]
    private string ReplaceNewlines(string numbers, string delimiter)
    {
        return numbers.Replace("\n", delimiter);
    }
     [Fact]
    private List<int> ExtractNumbers(string input, string delimiter)
    {
        return input.Split(new[] { delimiter }, StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToList();
    }
   [Fact]
    private void CheckForNegatives(List<int> numbers)
    {
        var negatives = numbers.Where(num => num < 0).ToList();

        if (negatives.Any())
        {
            string errorMessage = "negatives not allowed: " + string.Join(" ", negatives);
            throw new ArgumentException(errorMessage);
        }
    }
  [Fact]
    private int SumValidNumbers(List<int> numbers)
    {
        return numbers.Where(num => !IsGreaterThanLimit(num, 1000)).Sum();
    }
    [Fact]
    private bool IsGreaterThanLimit(int number, int limit)
    {
        return number > limit;
    }
}
