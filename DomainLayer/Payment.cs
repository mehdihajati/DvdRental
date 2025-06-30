namespace DomainLayer;
public class Payment
{
    public int Payment_id { get; set; }
    public int Customer_id { get; set; }
    public int Staff_id { get; set; }
    public int Rental_id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Payment_Date { get; set; }
    public Rental Rental { get; set; }
    public Customer Customer { get; set; }
    public Staff Staff { get; set; }
}
