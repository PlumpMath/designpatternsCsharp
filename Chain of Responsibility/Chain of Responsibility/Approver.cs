namespace Chain_of_Responsibility
{
    using System;

    public abstract class Approver
    {
        //Loan event
        public EventHandler<LoanEventArgs> Loan;

        //Loan event handler
        public abstract void LoanHandler(object sender, LoanEventArgs e);

        //set or get the next approver
        public Approver Successor { get; set; }

        //Constructor
        public Approver()
        {
            Loan += LoanHandler;
        }        

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs
            {
                Loan = loan
            }); 
        }

        public virtual void OnLoan(LoanEventArgs e)
        {
            Loan?.Invoke(this, e);
        }
    }
}
