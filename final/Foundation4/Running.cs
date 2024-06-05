namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double distance; 

        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            this.distance = distance;
        }

        public double GetDistanceValue()
        {
            return distance;
        }

        public void SetDistanceValue(double distance)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return GetDistanceValue();
        }

        public override double GetSpeed()
        {
            return (GetDistanceValue() / GetMinutes()) * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistanceValue();
        }
    }
}
