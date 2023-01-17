namespace DAL;
using BOL;
    public interface IDBManager{
        List<Car> GetAll();
        Car GetById(int id);
        void Insert(Car car);
        void Update(Car car);
        void Delete(int id);
    }
