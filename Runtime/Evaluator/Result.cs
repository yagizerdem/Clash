namespace Runtime.Evaluator;

interface Result{}
class EmptyResult : Result {}
class StringResult : Result
{
    public string Value { get; }

    public StringResult(string value)
    {
        this.Value = value;
    }
}