using System;

public class CryptoWalletProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Crypto Wallet] Processed GHC{transaction.Amount} for {transaction.Category}");
    }
}
