

namespace DomainLayer;

public class Country
{
    
    public int Country_id { get; set; }
    public string Country_Name { get; set; }
    public DateTime Last_update { get; set; }
    public ICollection<City> Cities { get; set; }
}
