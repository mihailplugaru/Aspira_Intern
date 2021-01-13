using System;


namespace Events
{
    delegate void ModifyUser(string message);
    class Program
    {
#if DEBUG
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Nme1", Password = "pass1" };
            Console.WriteLine($"The user is:  {user1}");


            user1.ChangePass += new ModifyUser(OnChangePassword);

            user1.Password = "pass22";


            Console.WriteLine($"The user is:  {user1}");
            Console.ReadKey();
        }

        static void OnChangePassword(string message)
        {
            Console.WriteLine(message);
        }
#else
        static void Main(string[] args)
        {
            CarShop carShop = new CarShop();
            carShop.CarsAreSold += CarsAreSold;

            carShop.SellCar();
            carShop.SellCar();
            carShop.SellCar();
            carShop.SellCar();
            carShop.SellCar();

            Console.ReadKey();
        }
#endif
        public static void CarsAreSold(object sender, EventArgs e)
        {
            Console.WriteLine("All cars are sold");
        }
    }
}
