using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Sports_equipment
{
    public class GameItem : IPrint
    {
        private string _description;
        private decimal _pricesDecimal;


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public decimal PricesDecimal
        {
            get => _pricesDecimal;
            set => _pricesDecimal = value;
        }
        
        // Implement the Constructor 
        public GameItem(string newDescription, double newPrice)
        {
            Description = newDescription;
            PricesDecimal = (decimal)newPrice;
        }

    /* Implementing method printItem */
        public void printItem()
        {
            Console.WriteLine($"GameItem - Description: {this.Description}");
            Console.WriteLine($"GameItem - Price €{this.PricesDecimal}");
        } 
        
       
    }
    
    
}