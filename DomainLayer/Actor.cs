

namespace DomainLayer;

public class Actor
{
    
    public int Actor_id { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public DateTime Last_update { get; set; }
    public ICollection<Film> Films { get; set; }
    public ICollection<Film_actor> Film_Actors { get; set; }

}
