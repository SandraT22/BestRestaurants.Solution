using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string ContactInformation { get; set; }
    public string OperationHours { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }

  }
}