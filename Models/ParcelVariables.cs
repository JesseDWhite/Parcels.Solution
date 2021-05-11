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

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }
    public static int GetPrice(int length, int width, int height, int weight)
    {
      int volume = length * width * height;
      int price = weight * volume;
      return price;
    }
  }
}