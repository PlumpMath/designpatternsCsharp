namespace Chain_of_Responsibility
{
    using System;
    using static System.Console;

    public class Manager:Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000)
                WriteLine($"{sender.GetType().Name} approved request# {e.Loan.Number}");
            else if (Successor != null)
                Successor.LoanHandler(this, e);
            else
                WriteLine($"Request# {e.Loan.Number} requires an executive meeting");
        }
    }
}
