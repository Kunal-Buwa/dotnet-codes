namespace DAL;
using BOL;
public class DBManager:IDBManager{
    public void Delete(int id)
    {
        using(var context = new CollectionContext())
        {
            context.Cars.Remove(context.Cars.Find(id));
            context.SaveChanges();
        }
    }

    public List<Car> GetAll()
    {
        using (var context = new CollectionContext())
        {
            var Cars=from cartable in context.Cars select cartable;
            return Cars.ToList<Car>();
        }
    }

    public Car GetById(int id)
    {
        using (var context = new CollectionContext())
        {
            var c1 = context.Cars.Find(id);
            return c1;
        }
    }

    public void Insert(Car car)
    {
        using (var context = new CollectionContext())
        {
            context.Cars.Add(car);
            context.SaveChanges();  
        }
    }

    public void Update(Car car)
    {
        using (var context = new CollectionContext())
        {
            var thecar = context.Cars.Find(car.CarID);
            thecar.CarName =car.CarName;
            thecar.Company=car.Company;
             thecar.Type=car.Type;
            context.SaveChanges();
        }
    }
}