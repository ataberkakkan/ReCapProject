using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.CarName);
}