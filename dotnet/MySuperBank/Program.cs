// See https://aka.ms/new-console-template for more information
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
            
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            /* 
            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attemp to overdraw");
                Console.WriteLine(account.Balance);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            } 
            */
        }
    }
}
