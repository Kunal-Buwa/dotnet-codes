namespace HR;
public abstract class Employee 
{

public int ID{get;set;}
public String FirstName{get;set;}
public String LastName{get;set;}
public String Email{get;set;}
public String ContactNo {get;set;}
public String Location{get;set;}
public DateTime BirthDate{get;set;}


public float DA{get;set;}
public float HRA{get;set}
public float BasicSalary{get;set;}

public Employee():this(1,"Kunal","Buwa","kunalbuwa8998@gmail.com","876698027","Nashik",new DateTime(1997,10,21),1000,1500,2000)
{

}
public Employee(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime bDate, float da, float hra, float bsal)
                    {
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Location=location;
        this.ContactNumber=contactNumber;
        this.BirthDate=bDate;
        this.BasicSalary=bsal;
        this.HRA=hra;
        this.DA=da;
                    }
public abstract void dowork();

public virtual float computepay()
{
    float pay=(DA*25)+BasicSalary+HRA;
    return pay;
}

public override String ToString()
{
    string str=string.Format("{0},{1},{3},{ 4},{5}",ID,FirstName,LastName,Email,ContactNo,Location);
    return str;
}






}