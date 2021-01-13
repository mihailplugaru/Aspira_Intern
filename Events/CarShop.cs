using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class CarShop
    {
        private Queue<string> cars = new Queue<string>();
        public CarShop()
        {
            cars.Enqueue("Opel");
            cars.Enqueue("BMW");
            cars.Enqueue("Mercedes");
        }

        public event EventHandler CarsAreSold;

        public void SellCar()
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("We just sold the {0}", cars.Dequeue());
            }
            else
            {
                OnCarsAreSold(EventArgs.Empty);
            }
        }

        protected virtual void OnCarsAreSold(EventArgs e)
        {
            CarsAreSold?.Invoke(this, e);
        }
    }
}
