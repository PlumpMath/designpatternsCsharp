namespace Chain_of_Responsibility
{
    using static System.Console;

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
                WriteLine($"Handled by ConcreteHandlerA");
            else
                if (_successor != null)
                _successor.HandleRequest(request);
        }
    }
}
