using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;


namespace Sports_equipment
{
    class Program
    {

        static private void SerializeCollection(IPrint[] collection, string filename)
        {
            string serialized = Serialize.serializeToDisk(collection, filename);

            Console.WriteLine("{0}", serialized);
        }

        static private IPrint[] DeserializeCollection (string filename)
        {
            return Serialize.deserializeFromFilename(filename);
        }

        static private int CountFromToLimit (int start, int limit)
        {
            int i = start;
            for (; i < limit; i++)
            {
                Console.WriteLine("Counter {0}", i);
            }
            return i;
        }

        static private int DoubleLimit(int limit)
        {
            return limit * 2;
        }

        static void Main()
        {
            
            // Initialize GameItem objects
            IPrint gameItem1 = new GameItem("Rubiks Cube", "455-RUB-96554", "Schildkroet", 14.95m, Currency.EUR);
            IPrint gameItem2 = new GameItem("Schloss Schwaenstein Puzzle", "124-RAB-9542", "Rabensteiner", 149.95m, Currency.EUR);
            // Initializing the sportItem Objects
            IPrint sportItem1 = new SportsItem("Touren Ski", "A45 670087", "Hagan", 295.95m, Currency.CHR);
            IPrint sportItem2 = new SportsItem("Football",  "B787 56333", "Adidas", 29.95m, Currency.USD);

            // Initialize a sportItem from type sportItem
            SportsItem sportsItem3 = new SportsItem("Langlaufski Fischer", "FSC 45998", "Fischer", 199.99m, Currency.EUR);
            // Initializing the salesItem objects
            IPrint saleItem1 = new SaleSports(25, "Fussballschuhe Nike", "NKE 256881", "Nike", 99.95m, Currency.USD);
            IPrint salesItem2 = new SaleSports(49, "Luftmatraze", "LMRZ 58799", "Luftikuss", 39.99m, Currency.JPY);

            // Initializing a struct box
            IPrint box1 = new Box(101.88, 12.97);
            IPrint box2 = new Box(227, 42);

            // putting all objects into an array. the Iprint type takes a object of type sportsItem as well.
            IPrint[] articleCollection =
                {sportItem1, sportItem2, sportsItem3, gameItem1, gameItem2, box1, box2, saleItem1, salesItem2};

            // call the printItem method from each element of the array  
            foreach (var article in articleCollection)
            {
                article.PrintItem();
            }

            // Feed the global settings in the Serializer Method
            string filename = "assigment4.json";

            SerializeCollection(articleCollection, filename);

            IPrint[] deserializedObjects = DeserializeCollection (filename);
            foreach (var item in deserializedObjects)
            {
                item.PrintItem();
            }

            Console.WriteLine("---- OUTPUT TASK 6.1 -----");

            // Create a new variable of type Subject 
            var sports = new Subject<IPrint>();

            // Create a new subscription with a single output of each object in array 
            var createObjects = sports.Subscribe(
                x => x.PrintItem()
            );

           
            // Simulate the feeding in of objects in the Subscription by iterating over the giben array
            for (int i = 0; i < 9; i++)
            {
                sports.OnNext(articleCollection[i]);
            }

            // Dispose the subscription after done 
            createObjects.Dispose();


            Console.WriteLine("---- OUTPUT TASK 6.2 -----");

            // Create a new Task to serialize the collection
            Task saveTask = new Task(() => SerializeCollection(articleCollection, filename));
            // start the serialization task
            saveTask.Start();

            Task counterTask = new Task(() => CountFromToLimit(0, 100));
           
            counterTask.Start();

           // var doubleLength = await Task.WhenAll(tasks: counterTask);
        }

     }
}