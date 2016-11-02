using System;

namespace Chain_of_Responsibility
{
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }
}
