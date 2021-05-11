using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int FinalPrice { get; set; }
    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      FinalPrice = 0;
    }
    public void GetPrice(int length, int width, int height, int weight)
    {
      int volume = length * width * height;
      int price = weight * volume;
      this.FinalPrice = price;
    }
  }
}