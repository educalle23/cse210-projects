using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime date;
        private int minutes;

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public int GetMinutes()
        {
            return minutes;
        }

        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{GetDate().ToShortDateString()} {this.GetType().Name} ({GetMinutes()} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }
}

