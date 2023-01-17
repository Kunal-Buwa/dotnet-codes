namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{
    public List<Product> GetAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        allProducts=DBManager.GetAllProducts();
        return allProducts; 
    }
    public List<Product> GetAllProductsFromFile(string path)
    {
          List<Product> allProducts = new List<Product>();
        allProducts=DBManager.GetAllProductsFromFile(path);
        return allProducts; 
    }
}
