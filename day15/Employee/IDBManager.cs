namespace DAL;
using BOL;
    public interface IDBManager{
        List<Employee> GetAll();
        Employee GetById(int empid);
        void Insert(Employee emp);
        void Update(Employee emp);
        void Delete(int empid);
    }
