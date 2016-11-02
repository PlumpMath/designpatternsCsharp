namespace Chain_of_Responsibility
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            //Approver Chain of responsibility
            Approver rohit = new Clerk();
            Approver rahul = new AssistantManager();
            Approver manoj = new Manager();

            rohit.Successor = rahul;
            rahul.Successor = manoj;

            //generate and process loan requests
            var loan = new Loan { Number = 2034, Amount = 24000, Purpose = "Laptop loan" };
            rohit.ProcessRequest(loan);

            loan = new Loan { Number = 2035, Amount = 42000, Purpose = "Bike Loan" };
            rohit.ProcessRequest(loan);

            loan = new Loan { Number = 2036, Amount = 156200, Purpose = "House Loan" };
            rohit.ProcessRequest(loan);

            ReadKey();
            
        }
    }
}
