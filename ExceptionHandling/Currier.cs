using System;

namespace ExceptionHandling
{
    public class Currier
    {
        public string Name { get; set; }

        public Currier(string name)
        {
            Name = name;
        }
        public void Deliver(int distance)
        {
            Move(distance / 3, Surface.Grass);

            try
            {
                Move(distance / 3, Surface.Obstacles);
            }
            catch (BrokenWheelException ex)
            {
                Console.WriteLine(ex.ToString());
                try
                {
                    RepairTheWheel();
                }
                catch (Exception e)
                {
                    throw;
                }
            }

            Move(distance / 3, Surface.Ground);

            GiveProduct();
        }

        private void GiveProduct()
        {
            Console.WriteLine("********** The product has been delivered *************");
        }

        private void Move(int distance, Surface surface)
        {
            switch (surface)
            {
                case Surface.Grass:
                    Console.WriteLine($"********** The currier:  {Name}  is {distance} m  closer to the customer. *************");
                    break;
                case Surface.Ground:
                    Console.WriteLine($"********** The currier:  {Name}  is {distance} m  closer to the customer. *************");
                    break;
                case Surface.Obstacles:
                    throw new BrokenWheelException($"********** The currier:  { Name } is in trouble, a wheel has broken. *************");
                default:
                    Console.WriteLine($"********** The currier:  {Name}  is somewhere he's not supposed to be! *************");
                    break;
            }
        }

        private void RepairTheWheel()
        {
            int random = new Random().Next(0, 2);
            if (random == 0)
            {
                throw new Exception("********** Could NOT REPAIR the wheel   :(    *************");
            }
            else
            {
                Console.WriteLine("********** The wheel IS REPAIRED  and the currier can go further. *************");
            }
        }
    }
}
