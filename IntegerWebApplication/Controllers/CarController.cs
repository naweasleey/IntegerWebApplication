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
                Varian = "FT86"
            });

            cars.Add(new Car()
            {
                IDRegistration = 2,
                Type = "SUV",
                Brand = "Toyota",
                Varian = "RAV4"
            });

            cars.Add(new Car()
            {
                IDRegistration = 3,
                Type = "Sedan",
                Brand = "Honda",
                Varian = "Accord"
            });

            cars.Add(new Car()
            {
                IDRegistration = 4,
                Type = "SUV",
                Brand = "Honda",
                Varian = "CRV"
            });

            cars.Add(new Car()
            {
                IDRegistration = 5,
                Type = "Sedan",
                Brand = "Honda",
                Varian = "City"
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

            //var car = cars.Where(x => x.Type == "Sedan").LastOrDefault(); //FirstOrDefault
            //ViewBag.Cars = new List<Car>() { car};

            //NOMOR 1
            //var cari = cars.Where(x => x.Brand == "Honda").FirstOrDefault();
            //ViewBag.Cars = new List<Car>() { cari };

            //NOMOR 2
            //var cari = cars.Where(x => x.Brand == "Honda" && x.Type == "Sedan");
            //ViewBag.Cars = cari;

            //NOMOR 3
            //var cari = cars.Where(x => x.Brand == "Honda" && x.Varian == "City").FirstOrDefault();
            //ViewBag.Cars = new List<Car>() { cari };

            //NOMOR 4
            //var cari = cars.Where(x => x.Brand == "Toyota");
            //ViewBag.Cars = cari;

            //NOMOR 5
            //var cari = cars.Where(x => x.Varian == "City");
            //ViewBag.Cars = cari;

            //NOMOR 6
            var cari = cars.Where(x => x.Type == "Sedan");
            ViewBag.Cars = cari;






            return View();
        }
    }
}
