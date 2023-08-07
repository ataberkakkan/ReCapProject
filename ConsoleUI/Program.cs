using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarDetails().Data)
{
    Console.WriteLine(car.CarName + " : " + car.BrandName + "  " + car.ColorName + "  " + car.DailyPrice);
}