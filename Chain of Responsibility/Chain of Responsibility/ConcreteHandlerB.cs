namespace Chain_of_Responsibility
{
    using static System.Console;

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10)
                WriteLine($"Handle by ConcreteHandlerB");
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }
}
