using System;
using System.Collections.Generic;

public class FinanceApp
{
    private List<Transaction> _transactions = new();

    public void Run()
    {
        var account = new SavingsAccount("ACC123", 1000m);

        var t1 = new Transaction(1, DateTime.Now, 150m, "Groceries");
        var t2 = new Transaction(2, DateTime.Now, 300m, "Utilities");
        var t3 = new Transaction(3, DateTime.Now, 600m, "Entertainment");

        var processor1 = new MobileMoneyProcessor();
        var processor2 = new BankTransferProcessor();
        var processor3 = new CryptoWalletProcessor();

        processor1.Process(t1);
        account.ApplyTransaction(t1);
        _transactions.Add(t1);

        processor2.Process(t2);
        account.ApplyTransaction(t2);
        _transactions.Add(t2);

        processor3.Process(t3);
        account.ApplyTransaction(t3);
        _transactions.Add(t3);
    }
}
