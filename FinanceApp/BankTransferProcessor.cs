using System;

public class BankTransferProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Bank Transfer] Processed GHC{transaction.Amount} for {transaction.Category}");
    }
}
