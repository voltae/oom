using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Sports_equipment
{
    public class GameItem : ItemBase
    {
        
        // Implement the Constructor 
        public GameItem(string newDescription, double newPrice)
        {
            Description = newDescription;
            Price = (decimal)newPrice;
        }

    /* Implementing method printItem */
         public override void printItem()
        {
            Console.WriteLine($"GameItem - Description: {this.Description}");
            Console.WriteLine($"GameItem - Price €{this.Price}");
        } 
        
    }
    
    
}