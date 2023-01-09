using Membership;
using HR;


Console.WriteLine("welcome to kunal home");
Console.WriteLine("********************************")

Console.WriteLine("Enter your email");
string email=Console.ReadLine();


Console.WriteLine("Enter your password");
string password=Console.ReadLine();

if(AuthManager.validate(email,password))
{
    Console.WriteLine("welcome to kunal's home");
    Employee emp =new SalesEmployee();
    emp.dowork();
    Console.WriteLine(emp);
    float salary = emp.computepay();
    Console.WriteLine("salary" +salary);
}
else 
{
    Console.WriteLine("invalid user");
}


Console.WriteLine("thankyou for visiting Nashik")