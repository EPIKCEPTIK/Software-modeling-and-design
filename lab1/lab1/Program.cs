namespace lab1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var flight = new Flight(1, "New Delhi", "Los Angeles", DateTime.Today.AddHours(20));
            var passenger = new Passenger(1, "Шмигельський Віталій");
            List<Passenger> passengers = new List<Passenger>();
            passengers.Add(passenger);
            flight.Passengers = passengers;
            var ticket = new Ticket(3, flight, "AC", 'Y', 'A', "5A", 32493, passenger);
            List<Ticket> tickets = new List<Ticket>();
            passenger.Tickets.Add(ticket);
            var qrCode = new QrCode(ticket);
            Console.WriteLine(ticket);         
            Console.WriteLine(flight);
        }
    }
}