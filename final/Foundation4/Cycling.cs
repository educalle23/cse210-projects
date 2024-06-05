namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double speed; // en kph

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            this.speed = speed;
        }

        public double GetSpeedValue()
        {
            return speed;
        }

        public void SetSpeedValue(double speed)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (GetSpeedValue() * GetMinutes()) / 60;
        }

        public override double GetSpeed()
        {
            return GetSpeedValue();
        }

        public override double GetPace()
        {
            return 60 / GetSpeedValue();
        }
    }
}
