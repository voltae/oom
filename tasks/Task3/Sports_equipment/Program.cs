using System;
using System.Dynamic;

namespace Sports_equipment
{

    
    class Program
    {
        static void Main(string[] args)
        {
            /* referencing first the variable. Item2 have to be declared in first place,
             * because it get initialized in the try block, this meens the variable is not visible outside that block */
            IPrint sportItem1;
            IPrint sportItem2;
            
            // Initialize GameItem 
            IPrint gameItem1 = new GameItem("Rubiks Cube", 14.95);
            IPrint gameItem2 = new GameItem("Schloß Schwaenstein Puzzle", 149.95);
            try
            {
               sportItem2 = new SportsItem("", "Adidas", 29.95, "B787 56333");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
                /* initializing correctly, but first output the error message
                 *  how can be forced a reentry of ther correct value? If this part get skipped, item2 would be uninitialized*/
                 sportItem2 = new SportsItem("Football", "Adidas", 29.95, "B787 56333");
             
            }
            
            // Initializing a struct box
            IPrint box1 = new Box(101.88, 12.97);
            IPrint box2 = new Box(227, 42);
            
            sportItem1 = new SportsItem("Touren Ski", "Hagan", 295.95, "A45 670087");

            IPrint[] articelCollection = {sportItem1, sportItem2, gameItem1, gameItem2, box1, box2};

            foreach (var article in articelCollection)
            {
                article.printItem();
            }


        }
    }
}