using System;

namespace EventPlanning
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Address { get; set; }

        public Event(string title, string description, DateTime date, string time, string address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string StandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
        }

        public virtual string FullDetails()
        {
            return StandardDetails();
        }

        public virtual string ShortDescription()
        {
            return $"Type: {this.GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
