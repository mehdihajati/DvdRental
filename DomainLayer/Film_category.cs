

namespace DomainLayer;

public class Film_category
{
    
    public int Id { get; set; }
    public int Film_id { get; set; }
    public Film Film { get; set; }
    public int Category_id { get; set; }
    public Category Category { get; set; }
    public DateTime LastUpdate { get; set; }
}
