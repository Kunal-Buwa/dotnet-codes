using Government;
using Accounts;
//Console.WriteLine("hii kunal");
centralGov c1=new centralGov();
 //c1.DeductIncomeTax();
// c1.Deposit(500);
TaxOperation IToperation =new TaxOperation(c1.DeductIncomeTax);
// Account a1=new Account(10000);
// a1.Withdraw(2000);
//   a1.Deposit(500);
//  IToperation();
 TaxOperation serviceoperation =new TaxOperation(c1.DeductServiceTax);
// serviceoperation();
TaxOperation protax = new TaxOperation(c1.DeductProfessionalTax);

Account act1 = new Account(6000);
//event regitration
//event configuration

act1.overbalance+=IToperation;
act1.overbalance+=serviceoperation;
act1.overbalance+=protax;

Console.WriteLine("Enter the amount you want to deposit");
 double amount=double.Parse(Console.ReadLine());
act1.Deposit(amount);


Console.WriteLine("Before Tax processing");
Console.WriteLine(act1);


act1.ProcessTax();
Console.WriteLine("After Tax processing");
Console.WriteLine(act1);


Console.WriteLine("Block account is called");
act1.Blockacc();
