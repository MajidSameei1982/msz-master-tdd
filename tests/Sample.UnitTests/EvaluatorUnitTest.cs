using SampleClassLibrary.Evaluators;

namespace Sample.UnitTests;

public class EvaluatorUnitTest
{
    [Fact]
    public void Evaluate_ShouldReturn_Even()
    {
        const int input = 6;
        Evaluator evaluator = new();
        var actual = evaluator.Evaluate(input);
        Assert.Equal("Even", actual);
    }
    [Fact]
    public void Evaluate_ShouldReturn_Odd()
    {
        const int input = 7;
        Evaluator evaluator = new();
        var actual = evaluator.Evaluate(input);
        Assert.Equal("Odd", actual);
    }
}