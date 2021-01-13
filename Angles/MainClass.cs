using System;

namespace Angles
{
    class MainClass
    {
        static ListOfAngles listOfAngles = ListOfAngles.GetListOfAngles();
        static void Main(string[] args)
        {
            var angle1 = new Angle(1000,1000,1000);
            var angle2 = new Angle(20,80,90);
            var angle3 = new Angle(30, 20, 23);
            var angle4 = new Angle(40, 40, 40);
            var angle5 = new Angle(50, 0, 0);
            var simpleAngle1 = new SimpleAngle(-100);
            var simpleAngle2 = new SimpleAngle(40);
            var simpleAngle3 = new SimpleAngle(50);

            SimpleAngle.AddAngleToListOfAngles(angle1);
            SimpleAngle.AddAngleToListOfAngles(angle2);
            SimpleAngle.AddAngleToListOfAngles(angle3);
            SimpleAngle.AddAngleToListOfAngles(angle4);
            SimpleAngle.AddAngleToListOfAngles(angle5);
            SimpleAngle.AddAngleToListOfAngles(simpleAngle1);
            SimpleAngle.AddAngleToListOfAngles(simpleAngle2);
            SimpleAngle.AddAngleToListOfAngles(simpleAngle3);

            angle1.DisplayAngleSize();
            angle2.DisplayAngleSize();
            angle3.DisplayAngleSize();
            angle4.DisplayAngleSize();
            angle5.DisplayAngleSize();
            simpleAngle1.DisplayAngleSize();
            simpleAngle2.DisplayAngleSize();
            simpleAngle3.DisplayAngleSize();

            Console.ReadKey();

            DisplayListOfAngles();
            Console.ReadKey();


            GetFirstsThreeBiggestAnglesFromList();
            Console.ReadKey();

            Console.WriteLine($"The approximate sum of {angle2} and {angle3} is: {SimpleAngleOperator.SumTwoAngles(angle2, angle3)}");
            Console.ReadKey();

            Console.WriteLine($"The precise sum of {angle2} and {angle3} is: {angle2 + angle3}");
            Console.ReadKey();

            Console.WriteLine($"The diference is: {SimpleAngleOperator.SubstractTwoAngles(angle2, angle3)}");
            Console.ReadKey();

            SimpleAngleOperator.CompareTheTwoAngles(angle2, angle3);
            Console.ReadKey();         
            
            SimpleAngleOperator.CompareTheTwoAngles(angle2, simpleAngle1);
            Console.ReadKey();
            SimpleAngleOperator.CompareTheTwoAngles(angle5, simpleAngle3);
            Console.ReadKey();

            Console.WriteLine(simpleAngle1 > angle4);
            Console.ReadKey();
        }

        public static void DisplayListOfAngles()
        {
            Console.WriteLine("\nA simple display of the List of Angles:");
            for (int i = 0; i < listOfAngles.Length; i++)
            {
                Console.WriteLine($"Element #{i+1} of list is: {listOfAngles[i]}");
            }
        }
        public static void GetFirstsThreeBiggestAnglesFromList()
        {
            Console.WriteLine("\nThe first 3 biggest angles from List of Angles are:");
            foreach (var angleSize in listOfAngles)
            {
                Console.WriteLine($"{angleSize} ");
            }
        }
    }
}
