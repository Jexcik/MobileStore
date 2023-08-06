namespace OnlineShop.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get;}
        public decimal Cost { get; }
        public string Description { get;}
        public string ImagePath { get; }


        //спецификация
        public string OperatingSystem { get; }
        public string ProcessorType { get; }
        public string Memory { get; }
        public string Camera { get; }

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Id = instanceCounter;
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;
            var specifications = Description.Split("; ");

            OperatingSystem = specifications[0];
            ProcessorType = specifications[1];
            Memory = specifications[2];
            Camera = specifications[3];

            instanceCounter += 1;
        }
    }
}
