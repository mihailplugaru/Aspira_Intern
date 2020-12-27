using System;
using System.Collections.Generic;

namespace Angles
{
    class ListOfAngles : IEnumerable<SimpleAngle>
    {
        internal List<SimpleAngle> listOfAngles = new List<SimpleAngle>();
        internal int Length => listOfAngles.Count;

        // Singleton//////////////////////////////////////////////
        private ListOfAngles() { }

        private static ListOfAngles _instance;
        public static ListOfAngles GetListOfAngles()
        {
            if (_instance == null)
            {
                _instance = new ListOfAngles();
            }
            return _instance;
        }
        //////////////////////////////////////////////////////////
        public void AddAngleSizeToListOfAngles(SimpleAngle angle)
        {
            listOfAngles.Add(angle);
        }

        public void DisplayListOfAngleSizeValues()
        {
            foreach (var item in listOfAngles)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        ////////////////////////////////////////////////////////
        public SimpleAngle this[int index]
        {
            get => listOfAngles[index];
            set => listOfAngles[index] = value;
        }
        ///////////////////////////////////////////////////////
        public IEnumerator<SimpleAngle> GetEnumerator()
        {
         //   listOfAngles.Sort();
         //   listOfAngles.Reverse();
            for (int p = 0; p <= listOfAngles.Count - 2; p++)
            {
                for (int i = 0; i <= listOfAngles.Count - 2; i++)
                {
                    if (listOfAngles[i] < listOfAngles[i + 1])
                    {
                        SimpleAngle t = listOfAngles[i + 1];
                        listOfAngles[i + 1] = listOfAngles[i];
                        listOfAngles[i] = t;
                    }
                }
            }
            yield return listOfAngles[0];
            yield return listOfAngles[1];
            yield return listOfAngles[2];
        }

        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        ///////////////////////////////////////////////////////
    }
}

