using System;
using System.Collections.Generic;
using BOL;
using DAL;
Console.WriteLine ("Welcome to ShowRoom Management System");
IDBManager dbm=new DBManager();
//upcasting
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
            List<Car> allcars=dbm.GetAll();
            foreach (var cartable in allcars)
            {
                Console.WriteLine(" CarID: {0}, CarName: {1}, Company: {2}, Type: {3}",
                                    cartable.CarID,cartable.CarName,cartable.Company,cartable.Type);
            }
        }
        break;
            
       // Insert new  Car
        case 2:
            var newcar = new Car()
            {
                CarID = 7,
                CarName = "Octavia",
                Company = "Scoda",
                Type="sedan"
            };
            dbm.Insert(newcar);
        break;

        // Update existing Department
        case 3:
        {
            var updatecar= new Car(){
                CarID = 7,
                CarName = "Alto",
                Company = "Maruti",
                Type="Hatchback"   
            };
            dbm.Update(updatecar);
        }
        break;
    
        // Delete existing Department
        case 4:
            dbm.Delete(7);
        break;
    
        //Exit from loop
        case 5:
            status = false;
        break;
    }
}
