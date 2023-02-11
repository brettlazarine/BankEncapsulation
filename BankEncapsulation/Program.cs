namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.Deposit(1);
            Console.WriteLine(account.GetBalance());
        }
    }
}
