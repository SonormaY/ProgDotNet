public class Termos
{
    public int Volume { get; set; }
    public double t { get; set; }
    static double k = 0.0005d;
    public DateTime Time { get; set; }

    public override string ToString()
    {
        return this.Volume.ToString();
    }

    public void CoolDown(DateTime timeEnd)
    {
        var res = timeEnd.Subtract(this.Time);
        System.Console.WriteLine($"Result: {Math.Round(this.t - res.TotalSeconds * k, 3)}");
    }

    public Termos(int Volume, double t)
    {
        this.Volume = Volume;
        this.t = t;
        this.Time = DateTime.Now;
    }
}

public class Team
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Sport { get; set; }

    public Team(string name, string country, string sport)
    {
        this.Name = name;
        this.Country = country;
        this.Sport = sport;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Country} {this.Sport}";
    }
}
public class Program
{

    public static void  Main(string[] args)
    {
        Termos termos = new Termos(1, 99.9d);
        System.Console.WriteLine(termos.ToString());
        var time = DateTime.Now.AddDays(1);
        termos.CoolDown(time);
        Team dauns = new Team("21321","312312","312312312");
        System.Console.WriteLine(dauns.ToString());
        dauns.Country = "poland";
        System.Console.WriteLine(dauns.ToString());
        List<Team> teams = new List<Team>();
        teams.Add(new Team("sample1","samle1","sample1"));
        teams.Add(new Team("sample3","samle3","sample3"));
        teams.Add(new Team("sample10","samle10","sample10"));
        teams.Add(new Team("sample4","samle4","sample4"));
        teams.Add(new Team("sample5","samle5","sample5"));
        teams.Sort((x, y) => x.Name.CompareTo(y.Name));
        System.Console.WriteLine("Sorted");
        foreach (var item in teams)
        {
            System.Console.WriteLine(item);
        }
    }
}