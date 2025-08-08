using System;

public class MobileMoneyProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Mobile Money] Processed GHC{transaction.Amount} for {transaction.Category}");
    }
}
