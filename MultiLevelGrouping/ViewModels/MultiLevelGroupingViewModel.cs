using System;
using System.Collections.ObjectModel;
using MultiLevelGrouping.Models;

namespace MultiLevelGrouping.ViewModels
{
    public class MultiLevelGroupingViewModel : BaseViewModel
    {
        private ObservableCollection<GroupedAccount> _groupedAccounts = new ObservableCollection<GroupedAccount>();
        public ObservableCollection<GroupedAccount> GroupedAccounts
        {
            get => _groupedAccounts;
            set
            {
                _groupedAccounts = value;
                OnPropertyChanged();
            }
        }

        public MultiLevelGroupingViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            #region Dummy data creation
            Account a = new Account
            {
                AccountID = 1,
                Name = "Account A",
                IBAN = "123-456"
            };

            Account b = new Account
            {
                AccountID = 2,
                Name = "Account B",
                IBAN = "456-123"
            };

            GroupedAccount signedAccountTransactions = new GroupedAccount()
            {
                Name = "Signed transactions"
            };

            GroupedTransaction groupA = new GroupedTransaction() { Account = a };
            groupA.Transactions.Add(new Transaction()
            {
                AccountID = a.AccountID,
                Beneficiary = "Beneficiary A",
                Amount = 500,
                Currency = "EUR"
            });

            groupA.Transactions.Add(new Transaction()
            {
                AccountID = a.AccountID,
                Beneficiary = "Beneficiary B",
                Amount = 50,
                Currency = "EUR"
            });

            signedAccountTransactions.Add(groupA);

			GroupedTransaction groupB = new GroupedTransaction() { Account = b };
			groupB.Transactions.Add(new Transaction()
			{
				AccountID = b.AccountID,
				Beneficiary = "Beneficiary A",
				Amount = 100,
				Currency = "EUR"
			});

			groupB.Transactions.Add(new Transaction()
			{
				AccountID = b.AccountID,
				Beneficiary = "Beneficiary B",
				Amount = 10,
				Currency = "EUR"
			});

            signedAccountTransactions.Add(groupB);

			GroupedAccount unSignedAccountTransactions = new GroupedAccount()
			{
				Name = "Unsigned transactions"
			};

            unSignedAccountTransactions.Add(groupA);
            unSignedAccountTransactions.Add(groupB);
            #endregion

            GroupedAccounts.Add(signedAccountTransactions);
            GroupedAccounts.Add(unSignedAccountTransactions);
		}
    }
}