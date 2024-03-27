//Створити клас Session, що визначає сеанс в кінотеатрі. 
namespace HW5;

public class Session
{
   public int Id { get; set; }
   public string MovieTitle { get; set; }
   public DateTime StartTime { get; set; }

   public Session(int id, string movieTitle, DateTime startTime)
   {
       Id = id;
       MovieTitle = movieTitle;
       StartTime = startTime;
   }
}