using System;
using System.Collections.Generic;


namespace CarDealership.Models {

  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}
