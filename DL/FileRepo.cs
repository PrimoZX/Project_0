namespace DL;

public class FileRepo : IRepo
{
    public FileRepo()
    { }

    private string filePath = "../DL/Restaurants.json";

    public List<Restaurant> GetAllRestaurants()
    {
        throw new NotImplementedException();
    }

    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        throw new NotImplementedException();
    }

    public void AddReview(int restaurantId, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public bool IsDuplicate(Restaurant restaurant)
    {
        throw new NotImplementedException();
    }
}
