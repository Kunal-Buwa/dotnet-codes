namespace Government;


//we have to an delegate method 
public delegate void TaxOperation(double amount);

public class centralGov
 {
//     public double amount;


//     public centralGov(double amount)
//     {
//          this.amount=amount;
//     }
    public void DeductIncomeTax(double amount)
    {
        Console.WriteLine("20% Income Tax is deducted from your account");
    }
    public void DeductServiceTax(double amount)
    {
        Console.WriteLine("10% income tax dis deducted from your account");
    }
    public void DeductProfessionalTax(double amount)
    {
        Console.WriteLine("8% Income Tax is deducted from your account");
    }
}