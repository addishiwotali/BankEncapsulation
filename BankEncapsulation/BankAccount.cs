namespace BankEncapsulation;

public class BankAccount
{
    public BankAccount()
    {
    }
    
    
    private double balance = 0;
    
    
    
    public void deposit(double amount)
    {
        balance = amount;
    }
    
    
     public double getBalance()
     {
        return balance;
     }
    

}
