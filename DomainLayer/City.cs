

namespace DomainLayer;

public class City
{
    
    public int City_id { get; set; }
    public string City_name { get; set; }
    // foreign key 
    public int Country_id { get; set; }
    public DateTime Last_update { get; set; }
    // relations
    public Country Country { get; set; }
    public ICollection<Address> Addresses { get; set; }
}
