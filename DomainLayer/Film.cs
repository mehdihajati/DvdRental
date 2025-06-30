namespace DomainLayer;

public class Film
{
    public int Film_id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Release_year { get; set; }
    public int Rental_duration { get; set; }
    public int Rental_Rate { get; set; }
    public int Length { get; set; }
    public double Replacement_Cost { get; set; }
    public double Rating { get; set; }
    public string Special_features { get; set; }
    public string FullText { get; set; }
    // foriegn key
    public int Language_id { get; set; }
    public Language Language { get; set; }
    public ICollection<Actor> Actors { get; set; }
    public ICollection<Category> Categories { get; set; }
    public ICollection<Film_actor> Film_Actors { get; set; }
    public ICollection<Film_category> Film_categories { get; set; }
    public ICollection<Inventory> Inventories { get; set; }
}
