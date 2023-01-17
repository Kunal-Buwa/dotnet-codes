using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstoreApp.Models;
using BOL;
using BLL;

namespace EstoreApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string path= @"F:\IACSD\dotnet\codes\dotnet-codes\day10\Ecommerce\product.json";
        CatalogManager manager = new CatalogManager();
         List<Product> allProducts =manager.GetAllProductsFromFile(path);
         this.ViewData["products"]=allProducts;
        return View();
    }
    //   public IActionResult Details( int id)
    // {
    //   CatalogManager manager=new CatalogManager();
    //   Product product=manager.GetProducts(id);
    //   this.ViewData["product"]=product;
    //   return View();
    // }
   
   
    
}