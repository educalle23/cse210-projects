namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        public int GetLaps()
        {
            return laps;
        }

        public void SetLaps(int laps)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (GetLaps() * 50) / 1000.0;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }
    }
}
