using System;

namespace Angles
{
    class SimpleAngle
    {
        static ListOfAngles listOfAngles = ListOfAngles.GetListOfAngles();

        private int sizeInDegrees;
        internal int SizeInDegrees
        {
            get { return sizeInDegrees; }
            set { sizeInDegrees = (value < 0 ? -value : value); }
        }

        public SimpleAngle(int degrees)
        {
            SizeInDegrees = degrees;
        }

        public static void AddAngleToListOfAngles(SimpleAngle angle)
        {
            listOfAngles.AddAngleSizeToListOfAngles(angle);
        }

        public override string ToString()
        {
            return SizeInDegrees + "  degrees ";
        }
        public virtual void DisplayAngleSize()
        {
            Console.WriteLine($"The size of simple angle is: {this.SizeInDegrees} degrees.");
        }
        public static bool operator >(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) > ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator <(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) < ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) == ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (ConvertDegreesToSeconds(angle1) != ConvertDegreesToSeconds(angle2))
            {
                return true;
            }
            return false;
        }

        public static SimpleAngle operator +(SimpleAngle angle1, SimpleAngle angle2)
        {
            return new SimpleAngle(angle1.SizeInDegrees + angle2.SizeInDegrees);
        }
        public static SimpleAngle operator -(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (angle1 > angle2)
            {
                return new SimpleAngle(angle1.SizeInDegrees - angle2.SizeInDegrees);
            }
            if (angle1 < angle2)
            {
                return new SimpleAngle(angle2.SizeInDegrees - angle1.SizeInDegrees);
            }
            return new SimpleAngle(0);
        }

        private static int ConvertDegreesToSeconds(SimpleAngle angle)
        {
            return angle.SizeInDegrees * 3600;
        }
    }
}
