namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.Write("How much would you like to deposit: ");
            var response = Console.ReadLine();
            double depositAmount;
            bool isNumber;
            isNumber = double.TryParse(response, out depositAmount);
            while (isNumber == false)
            {
                Console.WriteLine("Please enter a valid amount: ");
                response = Console.ReadLine();
                isNumber = double.TryParse(response, out depositAmount);
            }
            account.Deposit(depositAmount);
            Console.WriteLine($"Your new balance is ${account.GetBalance()}");
        }
    }
}
