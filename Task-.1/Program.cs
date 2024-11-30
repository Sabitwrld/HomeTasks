namespace Task_._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Standart", 40, 2);
            Room room2 = new Room("Gold", 100, 4);
            Room room3 = new Room("Premium", 200, 6);

            Hotel hotel = new Hotel("Ganja Hotel");

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);

            Console.WriteLine(room1.ShowInfo());
            Console.WriteLine(room2.ShowInfo());
            Console.WriteLine(room3.ShowInfo());
            
            try
            {
                hotel.MakeReservation(1);
                hotel.MakeReservation(1);
                hotel.MakeReservation(5);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
