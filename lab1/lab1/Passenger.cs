namespace lab1;

public class Passenger
{
    public int Id;
    public List<Ticket> Tickets = [];
    public string Full_name;

    public Passenger(int id, string full_name)
    {
        Id = id;
        Full_name = full_name;
       
    }

    public override string ToString()
    {
        return Full_name;
    }
}