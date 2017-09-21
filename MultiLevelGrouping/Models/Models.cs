using System;
using System.Collections.ObjectModel;

namespace MultiLevelGrouping.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string IBAN { get; set; }
    }

    public class Transaction
    {
        public int AccountID { get; set; }
        public string Beneficiary { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }

        public string DisplayAmount => $"{Amount} {Currency}";
    }

    public class GroupedTransaction
    {
        public Account Account { get; set; }
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();
    }

    public class GroupedAccount : ObservableCollection<GroupedTransaction>
    {
        public string Name { get; set; }
    }
}