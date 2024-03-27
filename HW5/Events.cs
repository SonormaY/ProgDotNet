namespace HW5;

public class TicketReservedEventArgs : EventArgs
{
   public Ticket ReservedTicket { get; set; }

   public TicketReservedEventArgs(Ticket ticket)
   {
       ReservedTicket = ticket;
   }
}

// Клас для аргументів події покупки квитка
public class TicketPurchasedEventArgs : EventArgs
{
   public Ticket PurchasedTicket { get; set; }

   public TicketPurchasedEventArgs(Ticket ticket)
   {
       PurchasedTicket = ticket;
   }
}