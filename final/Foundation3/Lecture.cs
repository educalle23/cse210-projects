using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, string time, string address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public string GetSpeaker()
        {
            return _speaker;
        }

        public void SetSpeaker(string speaker)
        {
            _speaker = speaker;
        }

        public int GetCapacity()
        {
            return _capacity;
        }

        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Lecture\nSpeaker: {GetSpeaker()}\nCapacity: {GetCapacity()}";
        }
    }
}
