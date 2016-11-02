namespace Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler _successor;

        public abstract void HandleRequest(int request);

        public void SetSuccessor(Handler successor) => _successor = successor;

    }
}
