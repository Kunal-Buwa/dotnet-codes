using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace EStoreWebAPI.Controllers;
using BOL;
using DAL;
[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly ILogger<CarsController> _logger;

    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCars")]
    [EnableCors()]
    public IEnumerable<Car> Get()
    {
        List<Car> allCars=new List<Car>();
        DBManager dbm = new DBManager();
        allCars=dbm.GetAll();
        return allCars;
    }

    /* http:\\localhost:8989\products\34  */
    // [Route("{id}")]
    // [HttpGet]
    // public  ActionResult<Product>  GetById(int id)
    // {
    //     //
    //     Product product = new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Balance = 10000 };

    //     if (product == null)
    //     {
    //         return NotFound();
    //     }
    //     return product;
    // }

    // [Route("{id}")]
    // [HttpDelete]
    // public IActionResult  Delete(int id)
    // {
    //     var product = new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Balance = 10000 };
    //     if (product == null)
    //     {
    //         return NotFound();
    //     } 
    //    //Remove Product
    //     return NoContent();
    // }

}