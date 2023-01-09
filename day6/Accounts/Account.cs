namespace Accounts;
using Government;
public class Account
{
public event TaxOperation overbalance;
public double Balance{get;set;}
public Account(double amount)
{
    this.Balance=amount;
}
public void Deposit(double amount)
{
   this.Balance+=amount;
   Console.WriteLine("balance is " + Balance);
  
}
public void Withdraw(double amount)
{
   this.Balance-=amount;
    Console.WriteLine("balance is " + Balance);

  
}
public override string ToString()
{
    return base.ToString() + "current balance=" + this.Balance; 
}
public void ProcessTax()
{
    if(this.Balance>=25000)
    {
        //raise an event
        Console.WriteLine("event is raised in PRocess tax");

        overbalance(this.Balance);
        Balance=
    }
    else
    {
         Console.WriteLine("event is not raised in process tax");
    }
}
public void Blockacc()
{
    if(this.Balance<=10000)
    {
        
         Console.WriteLine("event is raised in Block account");
        Console.WriteLine("your account is blocked");
         Console.WriteLine("email is send");
          Console.WriteLine("SMS is send");

    }
    else
    {
        Console.WriteLine("event is not raised in Blocked account");
    }
}
}
