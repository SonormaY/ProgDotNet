namespace HW5;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Створення сеансів
        var session1 = new Session(1, "Movie 1", new DateTime(2023, 4, 1, 18, 0, 0));
        var session2 = new Session(2, "Movie 2", new DateTime(2023, 4, 2, 20, 0, 0));
        var session3 = new Session(3, "Movie 3", new DateTime(2023, 4, 8, 15, 0, 0));

        // Створення квитків
        var ticket1 = new Ticket(1, 10.0, session1);
        var ticket2 = new Ticket(2, 12.0, session2);
        var ticket3 = new Ticket(3, 8.0, session3);

        // Створення каси
        var boxOffice = new BoxOffice();
        boxOffice.AddSession(session1);
        boxOffice.AddSession(session2);
        boxOffice.AddSession(session3);

        // Підписка на події
        boxOffice.TicketReserved += BoxOffice_TicketReserved;
        boxOffice.TicketPurchased += BoxOffice_TicketPurchased;

        Console.WriteLine("Ціна квитків до оновлення:");
        Console.WriteLine($"Квиток #{ticket1.Id}: {ticket1.Price} {ticket1.Session.StartTime.DayOfWeek}");
        Console.WriteLine($"Квиток #{ticket2.Id}: {ticket2.Price} {ticket2.Session.StartTime.DayOfWeek}");
        Console.WriteLine($"Квиток #{ticket3.Id}: {ticket3.Price} {ticket3.Session.StartTime.DayOfWeek}");
        Console.WriteLine();

        // Резервація квитків
        boxOffice.ReserveTicket(ticket1);
        boxOffice.ReserveTicket(ticket2);
        boxOffice.ReserveTicket(ticket3);
        Console.WriteLine();

        // Оновлення цін на квитки в залежності від дня тижня
        boxOffice.UpdateTicketPrices(ticket =>
        {
            if (ticket.Session.StartTime.DayOfWeek == DayOfWeek.Saturday || ticket.Session.StartTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return ticket.Price * 1.2; // Збільшення ціни на 20% у вихідні дні
            }
            return ticket.Price;
        });

        Console.WriteLine("Ціна квитків після оновлення:");
        Console.WriteLine($"Квиток #{ticket1.Id}: {ticket1.Price} {ticket1.Session.StartTime.DayOfWeek}");
        Console.WriteLine($"Квиток #{ticket2.Id}: {ticket2.Price} {ticket2.Session.StartTime.DayOfWeek}");
        Console.WriteLine($"Квиток #{ticket3.Id}: {ticket3.Price} {ticket3.Session.StartTime.DayOfWeek}");
        Console.WriteLine();
        
        // Покупка квитка
        boxOffice.PurchaseTicket(ticket1);
        boxOffice.PurchaseTicket(ticket2);
        boxOffice.PurchaseTicket(ticket3);
        Console.WriteLine();

        // Фільтрація сеансів
        var weekendSessions = boxOffice.GetWeekendSessions();
        var eveningSessions = boxOffice.GetSessionsAfterTime(new TimeSpan(18, 0, 0));

        Console.WriteLine("Сеанси у вихідні дні:");
        foreach (var session in weekendSessions)
        {
            Console.WriteLine($"{session.MovieTitle} - {session.StartTime}");
        }
        Console.WriteLine();

        Console.WriteLine("Сеанси після 18:00:");
        foreach (var session in eveningSessions)
        {
            Console.WriteLine($"{session.MovieTitle} - {session.StartTime}");
        }

        Console.WriteLine("Натисніть Enter для виходу.");
        Console.ReadLine();
    }

    private static void BoxOffice_TicketPurchased(object sender, TicketPurchasedEventArgs e)
    {
        Console.WriteLine($"Квиток #{e.PurchasedTicket.Id} був придбаний.");
    }
    private static void BoxOffice_TicketReserved(object sender, TicketReservedEventArgs e)
    {
        Console.WriteLine($"Квиток #{e.ReservedTicket.Id} був зарезервований.");
    }
}