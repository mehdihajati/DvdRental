

namespace DomainLayer;

public class Store
{
    
    public int Store_id { get; set; }
    public string Manager_staff_id { get; set; }
    public string Address_id { get; set; }
    public DateTime Last_update { get; set; }
    // foriegn key
    public int inventory_id { get; set; }
    public int Customer_id { get; set; }
    public ICollection<Staff> Staffs { get; set; }
    public ICollection<Inventory> Inventories { get; set; }
    public ICollection<Customer> Customers { get; set; }
}
