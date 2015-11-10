namespace ClrCoder.Starship
{
    using System;

    public class NuclearReactor
    {
        public TimeSpan GetRunningTimeForConsuption(double powerConsumption)
        {
            // We have actually Perpetual motion.
            return TimeSpan.MaxValue;
        }
    }
}
