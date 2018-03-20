using System;
using System.Dynamic;

namespace Sports_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize GameItem objects
            IPrint gameItem1 = new GameItem("Rubiks Cube", 14.95);
            IPrint gameItem2 = new GameItem("Schloß Schwaenstein Puzzle", 149.95);
            // Initializing the sportItem Objects
            IPrint sportItem1 = new SportsItem("Touren Ski", "Hagan", 295.95, "A45 670087");
            IPrint sportItem2 = new SportsItem("Football", "Adidas", 29.95, "B787 56333");
            
            // Initialize a sportItem from type sportItem
            SportsItem sportsItem3 = new SportsItem("Langlaufski Fischer", "Fischer", 199.99, "FSC 45998");
            // Initilizing the salesItem objects
            IPrint saleItem1 = new SaleSports(25, "Fussballschuhe Nike", 99.95, "NKE 256881", "Nike");
            IPrint salesItem2 = new SaleSports(49, "Luftmatraze", 39.99, "LMRZ 58799", "Luftikuss");

            // Initializing a struct box
            IPrint box1 = new Box(101.88, 12.97);
            IPrint box2 = new Box(227, 42);

            // putting all objects into an array. the Iprint type takes a object of type sportsItem as well.
            IPrint[] articelCollection =
                {sportItem1, sportItem2, sportsItem3, gameItem1, gameItem2, box1, box2, saleItem1, salesItem2};

            // call the printItem method from each element of the array  
            foreach (var article in articelCollection)
            {
                article.printItem();
            }

            
        }
    }
}