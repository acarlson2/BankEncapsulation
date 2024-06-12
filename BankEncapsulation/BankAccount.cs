public class BankAccount
{
    private double balance = 0;

    public BankAccount()
    {
        
    }

    public void Deposit(double amt)
    {
        balance += amt;
    }

    public void Withdraw(double amt)
    {
        balance -= amt;
    }

    public double GetBalance()
    {
        return balance;
    }
}