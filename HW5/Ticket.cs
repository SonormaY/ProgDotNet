//Створити клас Ticket, що представляє квиток. 
namespace HW5;

public class Ticket
{
   public int Id { get; set; }
   public double Price { get; set; }
   public Session Session { get; set; }

   public Ticket(int id, double price, Session session)
   {
       Id = id;
       Price = price;
       Session = session;
   }
}