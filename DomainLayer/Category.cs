namespace DomainLayer;

public class Category
{
    public int Category_id { get; set; }
    public string Name { get; set; }
    public DateTime LastUpdate { get; set; }
    public ICollection<Film> Films { get; set; }
    public ICollection<Film_category> Film_Categories { get; set; }
}
