using HR;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var emp = new Employee(){ID=1,FirstName="kunal",LastName="Buwa",Email="kunalbuwa8998@gmail.com",Contactnumber="8766980247"};
var employees = new List <Employee>();
employees.Add(new Employee(){ID=2,FirstName="avadhoot",LastName="pawar",Email="ap@gmail.com",Contactnumber="87247"});
employees.Add(new Employee(){ID=3,FirstName="avsdgt",LastName="sdfe",Email="ap@gmail.com",Contactnumber="8762247"});
employees.Add(new Employee(){ID=4,FirstName="adsf",LastName="pgareg",Email="ap@gmail.com",Contactnumber="8765247"});



app.MapGet("/", () => "Hello World!");
app.MapGet("/api/hello", () => "Hello kunal");
app.MapGet("/api/Employee", () =>emp );
app.MapGet("/api/employees",()=>employees);

app.Run();
