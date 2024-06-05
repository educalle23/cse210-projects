using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string title, string description, DateTime date, string time, string address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        // Getter and Setter for RSVPEmail
        public string GetRSVPEmail()
        {
            return _rsvpEmail;
        }

        public void SetRSVPEmail(string rsvpEmail)
        {
            _rsvpEmail = rsvpEmail;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Reception\nRSVP Email: {GetRSVPEmail()}";
        }
    }
}
