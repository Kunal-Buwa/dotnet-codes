namespace DAL;
using BOL;
public class DBManager:IDBManager{
    public void Delete(int id)
    {
        using(var context = new CollectionContext())
        {
            context.Emp.Remove(context.Emp.Find(id));
            context.SaveChanges();
        }
    }

    public List<Employee> GetAll()
    {
        using (var context = new CollectionContext())
        {
            var emp=from cartable in context.Emp select Employee;
            return emp.ToList<Car>();
        }
    }

    public Employee GetById(int id)
    {
        using (var context = new CollectionContext())
        {
            var e1 = context.Emp.Find(id);
            return e1;
        }
    }

    public void Insert(Employee e2)
    {
        using (var context = new CollectionContext())
        {
            context.Emp.Add(e2);
            context.SaveChanges();  
        }
    }

    public void Update(Employee emp)
    {
        using (var context = new CollectionContext())
        {
            var theemp = context.Emp.Find(emp.Empid);
            theemp.Ename =emp.Ename;
            theemp.Department=emp.Department;
            
            context.SaveChanges();
        }
    }
}