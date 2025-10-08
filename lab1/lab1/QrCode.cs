namespace lab1;

public class QrCode
{
    public Ticket Ticket;
    public int Ticket_id;

    public QrCode(Ticket ticket)
    {
        Ticket = ticket;
        Ticket_id = ticket.Id;
    }
}