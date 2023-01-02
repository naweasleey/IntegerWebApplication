using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            //NAMBAH DATA TANPA ARRAY
            var cars = new List<Car>(); //deklarasi 

            cars.Add(new Car()
            {
                IDRegistration = 1,
                Type = "Sedan",
                Brand = "Toyota",
                Varian = "Black"
            });

            cars.Add(new Car()
            {
                IDRegistration = 2,
                Type = "Sedan",
                Brand = "BMW",
                Varian = "Soft Purple"
            });

            cars.Add(new Car()
            {
                IDRegistration = 3,
                Type = "SUV",
                Brand = "Hyundai",
                Varian = "Black Doff"
            });


            //NAMBAH DATA BANYAK
            //var cars = new Car[] //array
            //{
            //    new Car{IDRegistration = 1, Type="Sedan", Brand="Toyota", Varian="Black"},
            //    new Car{IDRegistration = 2, Type="Sedan", Brand="BMW", Varian="Soft Purple"},
            //    new Car{IDRegistration = 3, Type="SUV", Brand="Hyundai", Varian="Black Doff"},
            //    new Car{IDRegistration = 4, Type="Honda", Brand="CRV", Varian="Maroon"}


            //};
            //ViewBag.Cars = cars; //untuk data yang lebih dari satu

            //MENGHAPUS DATA
            //var car1 = cars.Single(x => x.IDRegistration == 2);
            //cars.Remove(car1);

            //CARI
            //var car = cars.Where(x => x.Type == "Sedan");
            //ViewBag.Cars = car;

            var car = cars.Where(x => x.Type == "Sedan").LastOrDefault(); //FirstOrDefault
            ViewBag.Cars = new List<Car>() { car};

           



            return View();
        }
    }
}
