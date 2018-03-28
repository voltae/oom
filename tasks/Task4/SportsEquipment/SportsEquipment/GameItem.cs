using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Sports_equipment
{
    public class GameItem : ItemBase
    {

        // Implement the Constructor 
        public GameItem(string newDescription, string articleNumber, string brand, decimal newPrice, Currency currency)
        {
            Description = newDescription;
            ArticleNumber = articleNumber;
            Brand = brand;
            Price = new Price(newPrice, currency);

        }

    /* Implementing method printItem */
         public override void PrintItem()
        {
            Console.WriteLine($"{this.GetType().Name} - Description: { this.Description }");
            Console.WriteLine($"{this.GetType().Name} - Price {Price.Amount}");
            Console.WriteLine($"{this.GetType().Name} - Currency {Price.Unit}");
        } 
        
    }
    
    
}