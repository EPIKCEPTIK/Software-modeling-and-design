namespace lab1;

public class Ticket
{
    public int Id;
    public Flight Flight;
    public int FlightId;
    public Passenger Passenger;
    public string PassengerName;
    public string From;
    public string To;
    public string Carrier;
    public DateTime BoardingDate;
    public char Luggage;
    public char FlightClass;
    public string Seat;
    public float Price;

    public Ticket(int id, Flight flight,  string carrier, char luggage, char flightClass, string seat, float price, Passenger passenger)
    {
        Id = id;
        Flight = flight;
        Carrier = carrier;
        From = flight.From;
        To = flight.To;
        BoardingDate = flight.BoardingDate;
        Luggage = luggage;
        Seat = seat;
        Price = price;
        Passenger = passenger;
        PassengerName = Passenger.Full_name;
        FlightClass = flightClass;
        FlightId = flight.Id;

    }

    public override string ToString()
    {
        string ticketInfo = "";
        ticketInfo += $"Білет: '#{Id}'\n" +
                      $"Ім'я пасажира: {PassengerName}\n" +
                      $"Звідки: {From}\n" +
                      $"Куди: {To}\n" +
                      $"Код перевізника: {Carrier}\n" +
                      $"Номер рейсу: {FlightId} \n" +
                      $"Дата: {BoardingDate} \n" +
                      $"Багаж: {Luggage} \n" +
                      $"Клас: {FlightClass} \n" +
                      $"Місце: {Seat} \n";
        return ticketInfo;
    }
}