namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool isDone = false;

            Console.WriteLine("------------------------------");
            Console.WriteLine("-WELCOME TO YOUR BANK ACCOUNT-");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Would you like to make a deposit, withdraw, or see your balance?");
            string answer = Console.ReadLine();

            while(answer != "quit")
            {
                if(answer == "deposit")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("How much would you like to deposit?");
                    double dep = double.Parse(Console.ReadLine());
                    account.Deposit(dep);
                    Console.WriteLine($"You have deposited ${dep}");
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}");
                    Console.WriteLine("------------------------------");
                }
                else if(answer == "withdraw")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("How much would you like to withdraw?");
                    double wit = double.Parse(Console.ReadLine());
                    account.Withdraw(wit);
                    Console.WriteLine($"You have withdrawn ${wit}");
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}");
                    Console.WriteLine("------------------------------");
                }
                else if(answer == "see balance")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Your current balance is ${account.GetBalance()}");
                    Console.WriteLine("------------------------------");
                }
                
                Console.WriteLine("------------------------------");
                Console.WriteLine("        Anything else?        ");
                Console.WriteLine("------------------------------");
                answer = Console.ReadLine();
            }
            
        }
    }
}
