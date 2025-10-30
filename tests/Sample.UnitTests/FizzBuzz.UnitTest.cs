using SampleClassLibrary.FizzBuzzes;

namespace Sample.UnitTests;

public class FizzBuzzUnitTest
{
    [Fact]
    public void Start_Should_ReturnAListWithGivenRoundsLength()
    {
        const int rounds = 100;
        var actual = FizzBuzz.Start(rounds);
        Assert.Equal(rounds, actual.Count);
    }

    [Theory]
    [InlineData("Fizz", 2)]
    [InlineData("Buzz", 4)]
    [InlineData("FizzBuzz", 29)]
    public void Start_Should_ReturnAListWithProperFizzValues(string expected, int element)
    {
        const int rounds = 100;
        var actual = FizzBuzz.Start(rounds);
        Assert.Equal(expected, actual[element]);
    }
    // [Fact]
    // public void Start_Should_ReturnAListWithProperBuzzValues()
    // {
    //     const int rounds = 100;
    //     var actual = FizzBuzz.Start(rounds);
    //     Assert.Equal("Buzz", actual[4]);
    //     Assert.Equal("Buzz", actual[9]);
    // }
    // [Fact]
    // public void Start_Should_ReturnAListWithProperFizzBuzzValues()
    // {
    //     const int rounds = 100;
    //     var actual = FizzBuzz.Start(rounds);
    //     Assert.Equal("FizzBuzz", actual[14]);
    //     Assert.Equal("FizzBuzz", actual[29]);
    // }
}