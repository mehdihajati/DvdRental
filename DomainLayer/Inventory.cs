namespace DomainLayer;

public class Inventory
{
    public int Inventory_id { get; set; }
    public DateTime Last_update { get; set; }
    // foriegn key
    public int Film_id { get; set; }
    // foriegn key
    public int Store_id { get; set; }
    public Film Film { get; set; }
    public Store Store { get; set; }
    public ICollection<Rental> Rentals { get; set; }
}
