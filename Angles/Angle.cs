using System;

namespace Angles
{
    class Angle : SimpleAngle
    {
        private int sizeInMinutes;
        protected int SizeInMinutes
        {
            get { return sizeInMinutes; }
            set { sizeInMinutes = (value < 0 || value > 59) ? 59 : value; }
        }
        private int sizeInSeconds;
        protected int SizeInSeconds
        {
            get { return sizeInSeconds; }
            set { sizeInSeconds = (value < 0 || value > 59) ? 59 : value; }
        }

        public Angle(int degrees) : base(degrees)
        {
            SizeInDegrees = degrees;
            SizeInMinutes = 0;
            SizeInSeconds = 0;
        }
        public Angle(int degrees, int minutes, int seconds) : base(degrees)
        {
            SizeInDegrees = degrees;
            SizeInMinutes = minutes;
            SizeInSeconds = seconds;
        }

        public override string ToString()
        {
            return SizeInDegrees + "  degrees " + SizeInMinutes + " minutes " + SizeInSeconds + " seconds ";
        }
        public override void DisplayAngleSize()
        {
            Console.WriteLine($"The size of the angle is: {this.SizeInDegrees} degrees, {this.SizeInMinutes} minutes, {this.SizeInSeconds} seconds.");
        }

        public static Angle operator +(Angle angle1, Angle angle2)
        {
            return ConvertSecondsToAngle(ConvertDegreesToSeconds(angle1) + ConvertDegreesToSeconds(angle2));
        }
        public static Angle operator -(Angle angle1, Angle angle2)
        {
            if (angle1 > angle2)
            {
                return ConvertSecondsToAngle(ConvertDegreesToSeconds(angle1) - ConvertDegreesToSeconds(angle2));
            }
            if (angle1 < angle2)
            {
                return ConvertSecondsToAngle(ConvertDegreesToSeconds(angle2) - ConvertDegreesToSeconds(angle1));
            }
            return ConvertSecondsToAngle(0);
        }
        public static bool operator >(Angle angle1, Angle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) > ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Angle angle1, Angle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) < ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Angle angle1, Angle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) == ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Angle angle1, Angle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) != ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        private static int ConvertDegreesToSeconds(Angle angle)
        {
            return angle.SizeInDegrees * 3600 + angle.SizeInMinutes * 60 + angle.SizeInSeconds;
        }

        private static Angle ConvertSecondsToAngle(double value)
        {
            int degrees = (int)(value / 3600);
            double fullRezult = value / 3600;
            int minutes = (int)(60 * (fullRezult - degrees));
            fullRezult = (60 * (fullRezult - degrees));
            int seconds = (int)(60 * (fullRezult - minutes));
            return new Angle(degrees, minutes, seconds);
        }
    }
}
