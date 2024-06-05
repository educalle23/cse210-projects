using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        public string Speaker { get; set; }
        public int Capacity { get; set; }

        public Lecture(string title, string description, DateTime date, string time, string address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }
    }
}
