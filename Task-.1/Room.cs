namespace Task_._1
{
    public class Room
    {
        private static int _idCount = 0;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(string name, decimal price, int personCapacity)
        {
            Id = ++_idCount;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price:C}, Person Capacity: {PersonCapacity}, Is Available: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
