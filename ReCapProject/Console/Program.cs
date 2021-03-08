using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.InMemory;
using ReCapProject.Entities;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
