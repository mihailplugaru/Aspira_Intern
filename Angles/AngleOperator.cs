using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles
{
    class SimpleAngleOperator
    {
        public static SimpleAngle SumTwoAngles(SimpleAngle angle1, SimpleAngle angle2)
        {
            return angle1 + angle2;
        }

        public static SimpleAngle SubstractTwoAngles(SimpleAngle angle1, SimpleAngle angle2)
        {
            if (angle1 > angle2)
            {
                return angle1 - angle2;
            }
            if (angle1 < angle2)
            {
                return angle2 - angle1;
            }
            return new SimpleAngle(0);
        }

        public static void CompareTheTwoAngles(SimpleAngle angle1, SimpleAngle angle2)
        {
            if(angle1 > angle2)
            {
                Console.WriteLine($"First angle is bigger! | {angle1}| > | {angle2}|");
            }
            if (angle1 < angle2)
            {
                Console.WriteLine($"Second angle is bigger!  | {angle1}| < | {angle2}|");
            }
            if (angle1 == angle2)
            {
                Console.WriteLine($"The angles are the same size!  | {angle1}| = | {angle2}|");
            }
        }



    }
}
