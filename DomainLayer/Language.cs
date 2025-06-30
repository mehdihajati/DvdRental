

namespace DomainLayer;

public class Language
{
    
    public int Language_id { get; set; }
    public string Name { get; set; }
    public DateTime LastUpdate { get; set; }
    public ICollection<Film> Films { get; set; }
}
