namespace Runtime.Evaluator.Interface;
interface IEvaluator<T> where T : Result
{
    public T Evaluate();
}