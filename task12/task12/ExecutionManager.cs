//Implement functionality
public class ExecutionManager
{
    public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
    //Add delegates for sum, substrat and multiply here
    Func<int> _sum;
    Func<int> _substrat;
    Func<int> _multiply;

    public ExecutionManager()
    {

    }
    public void PopulateFunctions(Func<int>sum, Func<int> substrat, Func<int> multiply)
    {
        _sum = sum;
        _substrat = substrat;
        _multiply = multiply;
    }
    public void PrepareExecution()
    {
        FuncExecute = new Dictionary<Operation, Func<int>>();
        //fill dictionary here
        FuncExecute.Add(Operation.Sum, _sum);
        FuncExecute.Add(Operation.Multiply, _multiply);
        FuncExecute.Add(Operation.Subtract, _substrat);
    }
}