public class Account{
    public float balance;
  
   //default constructor
    public Account()
    {
        balance=1000;
    }
    //parameterized conntr
    public Account(float bal)
    {
        this.balance=bal;
    }

    //getter setter
    public float GetBalance()
    {
         return this.balance;
    }

    public void SetBalance(float amount)
    {
        this.balance=amount;
    }
    public void Withdraw(float amount)
    {
        if(balance==0)
        {
            Console.WriteLine("insufficent funds");
        }
        balance=balance-amount;
        Console.WriteLine("total balance is" +balance);
    }
    // public void Deposit(float amount)
    // {
    //   balance = balance + Deposit;
    //   Console.WriteLine("total balance is" +balance);
    // }
    
    public void Deposit(float amount){
        this.balance+=amount;
        Console.WriteLine("total balance is" +balance);
    }
    ~Account()
    {
        //DeInitialization


    }
    
}