using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;


namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makemodel, int price, int miles)
    {
      Car myCar = new Car(makemodel, price, miles);
      return RedirectToAction("Index");
    }


  }
}
