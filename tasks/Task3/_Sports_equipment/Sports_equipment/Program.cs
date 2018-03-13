using System;

namespace Sports_equipment
{

    class SportItem
    {
        private String _description;
        private String _brand;
        private Decimal _price;
        private String _articleNumber;

        public SportItem(String description, String brand, Decimal price, String articleNumber) 
        {
            _description = description;
            _brand = brand;
            _price = price;
            _articleNumber = articleNumber;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new SportItem("Touren Ski", "Hagan", (decimal)249.95, "A2356785");
                
            Console.WriteLine("Test Output");
        }
    }
}
