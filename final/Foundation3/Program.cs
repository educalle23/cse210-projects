using System;

public class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

public abstract class Event
{
    private string Title { get; set; }
    private string Description { get; set; }
    private DateTime Date { get; set; }
    private DateTime Time { get; set; }
    private Address Address { get; set; }

    protected Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToShortTimeString()}\nAddress: {Address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

public class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

public class Reception : Event
{
    private string RSVPEmail { get; set; }

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {RSVPEmail}";
    }
}

public class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}

public class Program
{
    public static void Main()
    {
        // Creating Address instances
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Othertown", "ON", "Canada");
        Address address3 = new Address("789 Oak Blvd", "Sometown", "CA", "USA");

        // Creating Event instances
        Lecture lecture = new Lecture("Tech Trends", "A lecture on the latest in technology", new DateTime(2024, 6, 15), new DateTime(2024, 6, 15, 10, 0, 0), address1, "Dr. John Smith", 150);
        Reception reception = new Reception("Networking Event", "An evening of networking with professionals", new DateTime(2024, 7, 10), new DateTime(2024, 7, 10, 18, 0, 0), address2, "rsvp@event.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor picnic with games and food", new DateTime(2024, 8, 20), new DateTime(2024, 8, 20, 12, 0, 0), address3, "Sunny with a chance of clouds");

        // Creating a list of events
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Displaying event details
        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}
 