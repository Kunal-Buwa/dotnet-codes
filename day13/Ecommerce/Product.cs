namespace Webapi;

public class Product {
    public int prodid {get;set;}
    public string Name {get;set;}


    public Product()
    {

    }

    public Product(int prodid,string Name)
    {
        this.prodid=prodid;
        this.Name=Name;
    }
}