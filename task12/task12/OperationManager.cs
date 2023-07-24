public class OperationManager
{
    private int _first;
    private int _second;
    private ExecutionManager executionManager;

    public OperationManager(int first, int second)
    {
        _first = first;
        _second = second;
        executionManager = new ExecutionManager();
        executionManager.PopulateFunctions(delegate () { return _first + _second; },
                                           delegate () { return _first - _second; },
                                           delegate () { return _first * _second; });
        executionManager.PrepareExecution();
    }
    public int Execute(Operation operation)
    {
       return executionManager.FuncExecute.GetValueOrDefault(operation).Invoke();
    }
}