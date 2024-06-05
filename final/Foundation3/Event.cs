using System;

namespace EventPlanning
{
    public class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private string _time;
        private string _address;

        public Event(string title, string description, DateTime date, string time, string address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        // Getter and Setter for Title
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        // Getter and Setter for Description
        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        // Getter and Setter for Date
        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }

        // Getter and Setter for Time
        public string GetTime()
        {
            return _time;
        }

        public void SetTime(string time)
        {
            _time = time;
        }

        // Getter and Setter for Address
        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string address)
        {
            _address = address;
        }

        public virtual string StandardDetails()
        {
            return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate().ToShortDateString()}\nTime: {GetTime()}\nAddress: {GetAddress()}";
        }

        public virtual string FullDetails()
        {
            return StandardDetails();
        }

        public virtual string ShortDescription()
        {
            return $"Type: {this.GetType().Name}\nTitle: {GetTitle()}\nDate: {GetDate().ToShortDateString()}";
        }
    }
}
