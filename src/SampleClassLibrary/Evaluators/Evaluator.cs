namespace SampleClassLibrary.Evaluators;

public class Evaluator
{
    public string Evaluate(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}