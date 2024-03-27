//c. Створити клас BoxOffice, який відповідає за продаж квитків та оновлення цін. 
//d. Використати делегати для оновлення цін на квитки в залежності від дня тижня, часу сеансу тощо. 
//e. Створити події для реагування на резервації та покупки квитків. 
namespace HW5;

public delegate double PriceUpdateDelegate(Ticket ticket);
public class BoxOffice
{
   private List<Ticket> tickets = new List<Ticket>();
   private List<Session> sessions = new List<Session>();

   // Подія для резервації квитка
   public event EventHandler<TicketReservedEventArgs> TicketReserved;

   // Подія для покупки квитка
   public event EventHandler<TicketPurchasedEventArgs> TicketPurchased;

   // Метод для резервації квитка
   public void ReserveTicket(Ticket ticket)
   {
       tickets.Add(ticket);
       OnTicketReserved(new TicketReservedEventArgs(ticket));
   }

   // Метод для покупки квитка
   public void PurchaseTicket(Ticket ticket)
   {
       tickets.Remove(ticket);
       OnTicketPurchased(new TicketPurchasedEventArgs(ticket));
   }

   // Метод для оновлення цін на квитки
   public void UpdateTicketPrices(PriceUpdateDelegate priceUpdateDelegate)
   {
       foreach (var ticket in tickets)
       {
           ticket.Price = priceUpdateDelegate(ticket);
       }
   }

   // Метод для знаходження сеансів у вихідні дні
   public IEnumerable<Session> GetWeekendSessions()
   {
       return sessions.Where(s => s.StartTime.DayOfWeek == DayOfWeek.Saturday || s.StartTime.DayOfWeek == DayOfWeek.Sunday);
   }

   // Метод для знаходження сеансів після певного часу
   public IEnumerable<Session> GetSessionsAfterTime(TimeSpan time)
   {
       return sessions.Where(s => s.StartTime.TimeOfDay >= time);
   }

   // Метод для додавання сеансу
   public void AddSession(Session session)
   {
       sessions.Add(session);
   }

   // Виклик подій
   protected virtual void OnTicketReserved(TicketReservedEventArgs e)
   {
       EventHandler<TicketReservedEventArgs> handler = TicketReserved;
       handler?.Invoke(this, e);
   }

   protected virtual void OnTicketPurchased(TicketPurchasedEventArgs e)
   {
       EventHandler<TicketPurchasedEventArgs> handler = TicketPurchased;
       handler?.Invoke(this, e);
   }
}