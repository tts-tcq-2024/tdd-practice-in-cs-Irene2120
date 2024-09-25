using System;
using System.Collections.Generic;
using Xunit;

public class StringCalculatorAddTests
{
    [Fact]
    public void ExpectZeroForEmptyInput()
    {
        int expectedResult = 0;
        string input = "";
        StringCalculator objUnderTest = new StringCalculator();
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
    }

  [Fact]
    public void ExpectZeroForSingleZero()
    {
        int expectedResult = 0;
        string input = "0";
        StringCalculator objUnderTest = new StringCalculator();
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
    }

  [Fact]
    public void ExpectSumForTwoNumbers()
    {
        int expectedResult = 3;
        string input = "1,2";
        StringCalculator objUnderTest = new StringCalculator();
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
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
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
    }

  [Fact]
    public void IgnoreNumbersGreaterThan1000()
    {
        int expectedResult = 1;
        string input = "1,1001";
        StringCalculator objUnderTest = new StringCalculator();
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
    }

    [Fact]
    public void ExpectSumWithCustomDelimiter()
    {
        int expectedResult = 3;
        string input = "//;\n1;2";
        StringCalculator objUnderTest = new StringCalculator();
        int actualResult = objUnderTest.Add(input);
        Assert.Equal(actualResult, expectedResult);
    }
}









/*public class StringCalculatorAddTests
{
    private readonly StringCalculator_stringCalculator;

    public StringCalculatorAddTests();
    {
        _stringCalculator = new StringCalculator();
    }
    [Fact]
    [Theory]
    [InlineData("",0]
    [InlineData("0",0)]
    [InlineData("5",5)]
    [InlineData("1,2",3)]
    [InlineData("1\n2,3",3)]
    [InlineData("//;\n1;2",3)]
    [InlineData("1,1001",1)]
    [InlineData("1,2,3,4,5",15)]
    public void Add_ShouldReturnExpectedResult(string input,int expected)
        {
            int result =_stringCalculator.Add(input);
            Assert.Equal(expected,result);
        }
    [Fact]
    [Theory]
    [InlineData("-1,2",Negatives not allowed: -1")]
    [InlineData("-1,-2","Negatives not allowed: -1,-2")]
    [InlineData("//;\n-1;2",Negatives not allowed: -1")]
    public void Add_InputContainsNegativeNumbers_ShouldThrowException(string input, string expectedMessage)
        {
            var exception = Assert.Throws<InvalidOperationException>(() => _stringCalculator.Add(input));
            Assert.Equal(exceptedMessage, exception.Message);
        }
    }*/
                
            
                                            

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
