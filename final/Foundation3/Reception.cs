using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        public string RSVPEmail { get; set; }

        public Reception(string title, string description, DateTime date, string time, string address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            RSVPEmail = rsvpEmail;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
        }
    }
}
