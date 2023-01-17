using System;
using System.Collections.Generic;
using BOL;
using DAL;
Console.WriteLine ("Welcome to Employee Management System");
IDBManager dbm=new DBManager();
bool status=true;
// Console based Menu driven User Interface
while(status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");

    switch(int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
        {
            List<Car> allemp=dbm.GetAll();
            foreach (var employee in allemp)
            {
                Console.WriteLine(" Empid: {0}, Ename: {1}, Department: {2}",
                                    employee.Empid,employee.Ename,employee.Department);
            }
        }
        break;
            
       // Insert new  Car
    //     case 2:
    //         var newcar = new Car()
    //         {
    //             CarID = 7,
    //             CarName = "Octavia",
    //             Company = "Scoda",
    //             Type="sedan"
    //         };
    //         dbm.Insert(newcar);
    //     break;

    //     // Update existing Department
    //     case 3:
    //     {
    //         var updatecar= new Car(){
    //             CarID = 7,
    //             CarName = "Alto",
    //             Company = "Maruti",
    //             Type="Hatchback"   
    //         };
    //         dbm.Update(updatecar);
    //     }
    //     break;
    
    //     // Delete existing Department
    //     case 4:
    //         dbm.Delete(7);
    //     break;
    
    //     //Exit from loop
    //     case 5:
    //         status = false;
    //     break;
    // }
    }
}
