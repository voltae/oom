using System;
using System.Collections.Generic;

namespace Sports_equipment
{
    class Program
    {

        static void Main(string[] args)
        {
            // Initialize GameItem objects
            IPrint gameItem1 = new GameItem("Rubiks Cube", "455-RUB-96554", "Schildkroet", 14.95m, Currency.EUR);
            IPrint gameItem2 = new GameItem("Schloss Schwaenstein Puzzle", "124-RAB-9542", "Rabensteiner", 149.95m, Currency.EUR);
            // Initializing the sportItem Objects
            IPrint sportItem1 = new SportsItem("Touren Ski", "Hagan", "A45 670087", 295.95m, Currency.CHR);
            IPrint sportItem2 = new SportsItem("Football", "Adidas", "B787 56333", 29.95m, Currency.USD);

            // Initialize a sportItem from type sportItem
            SportsItem sportsItem3 = new SportsItem("Langlaufski Fischer", "FSC 45998", "Fischer", 199.99m, Currency.EUR);
            // Initializing the salesItem objects
            IPrint saleItem1 = new SaleSports(25, "Fussballschuhe Nike", "NKE 256881", "Nike", 99.95m, Currency.USD);
            IPrint salesItem2 = new SaleSports(49, "Luftmatraze", "LMRZ 58799", "Luftikuss", 39.99m, Currency.JPY);

            // Initializing a struct box
            IPrint box1 = new Box(101.88, 12.97);
            IPrint box2 = new Box(227, 42);

            // putting all objects into an array. the Iprint type takes a object of type sportsItem as well.
            IPrint[] articelCollection =
                {sportItem1, sportItem2, sportsItem3, gameItem1, gameItem2, box1, box2, saleItem1, salesItem2};

            // call the printItem method from each element of the array  
            foreach (var article in articelCollection)
            {
                article.PrintItem();
            }

            // Feed the global settings in the Serializer Method
            string filename = "assigment4.json";

            string serialized = Serialize.serializeToDisk(articelCollection, filename);

            Console.WriteLine("{0}", serialized);

            IPrint[] deserializedObjects = Serialize.deserializeFromFilename (filename);
            foreach (var item in deserializedObjects)
            {
                item.PrintItem();
            }
        }


       

    }
}