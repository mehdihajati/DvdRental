

namespace DomainLayer;

public class Rental
{
    
    public int Rental_id { get; set; }
    public DateTime Rental_Date { get; set; }
    // foriegn key start
    public int inventory_id { get; set; }
    public int Customer_id { get; set; }
    public int Staff_id { get; set; }
    // foriegn key end
    public DateTime Return_Date { get; set; }
    public DateTime Last_update { get; set; }
    // relations
    public Inventory Inventory { get; set; }
    public Customer Customer { get; set; }
    public Staff Staff { get; set; }
    public ICollection<Payment> Payments { get; set; }
    // relations end
}
