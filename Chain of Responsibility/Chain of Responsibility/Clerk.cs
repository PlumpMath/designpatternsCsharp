namespace Chain_of_Responsibility
{
    using System;
    using static System.Console;

    public class Clerk : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 25000)
                WriteLine($"{this.GetType().Name} approved request# {e.Loan.Number}");
            else if (Successor != null)
                Successor.LoanHandler(this, e);
        }
    }
}
