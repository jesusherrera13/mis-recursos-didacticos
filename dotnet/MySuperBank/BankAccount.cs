namespace MySuperBank
{
    class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }   
        public decimal Balance { 
            get
            {
                decimal balance = 0;

                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            } 
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount deposit must be positive");
            }

            if(Balance - amount < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
