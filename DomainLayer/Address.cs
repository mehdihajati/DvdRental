

namespace DomainLayer;

public class Address
{
    public int Address_id { get; set; }
    public string Address_1 { get; set; }
    public string Address_2 { get; set; }
    public string District { get; set; }
    // foreign key
    public int City_id { get; set; }
    public string Postal_code { get; set; }
    public string Phone { get; set; }
    public DateTime Last_update { get; set; }
    // relations
    public City City { get; set; }
}
