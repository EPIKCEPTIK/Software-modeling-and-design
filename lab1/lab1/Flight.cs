namespace lab1;

public class Flight
{
    public int Id;
    public string From;
    public string To;
    public DateTime BoardingDate;

    public List<Passenger> Passengers = [];
    
    public Flight(int id, string from, string to, DateTime boardingDate)
    {
        Id = id;
        From = from;
        To = to;
        BoardingDate = boardingDate;
        
    }

    public override string ToString()
    {
        string flightInfo = $"Номер рейсу: {Id}, {From}, {To}, {BoardingDate}\n";
        flightInfo += "Зареєстровані пасажири: ";
        foreach (var passenger in Passengers)
        {
            flightInfo += $"'{passenger}' ";
        }
        return flightInfo;
    }
}