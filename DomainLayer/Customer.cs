namespace DomainLayer;
public class Customer
{
    public int Customer_id { get; set; }
    // foriegn key start
    public int Address_id { get; set; }
    public int Store_id { get; set; }
    // foriegn key end
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Email { get; set; }
    public bool Activebool { get; set; }
    public DateTime Create_date { get; set; }
    public DateTime Last_update { get; set; }
    public Store Store { get; set; }
    public Address Address { get; set; }
    public ICollection<Rental> Rentals { get; set; }
    public ICollection<Payment> Payments { get; set; }
}
