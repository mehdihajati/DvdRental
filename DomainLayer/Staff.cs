namespace DomainLayer;

public class Staff
{
    public int Staff_id { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    // foreign key start
    public string Address_id { get; set; }
    public int Store_id { get; set; }
    // foreign key end
    public string Email { get; set; }
    public bool Active { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime Last_update { get; set; }
    public string Picture { get; set; }
    public Address Address { get; set; }
    public Store StoreManaged { get; set; }
    public ICollection<Rental> Rentals { get; set; } 
    public ICollection<Payment> Payments { get; set; }
}
