using Microsoft.AspNetCore.Mvc;
using mystudent.Models;
namespace mystudent.Controllers

{
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    
    private readonly DBStudentContext _dbContext;

    public StudentController(DBStudentContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
     [Route("GetStudents")]
    public IActionResult GetStudents()
    {
       List <Student> list=_dbContext.Students.ToList();
      return StatusCode (StatusCodes.Status200OK,list);
    }
}
}

