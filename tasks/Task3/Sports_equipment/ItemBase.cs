using System;
using System.ComponentModel;

namespace Sports_equipment
{
    // The base class adopt the IPrint Interface,
    public class ItemBase : IPrint
    {
        /* This fields share all Item Child classes */
        private String _description;
        private String _brand;
        private decimal _price;
        private String _articleNumber;


        // virtual method 
        public virtual void printItem()
        {}
        
        
        // Getter - Setter of all four fields 

        // Description - with Exception
        public string Description
        {
            get => _description;
            set
            {
                if (value == "") throw new Exception("Description must be set");
                else _description = value;
            }
        }
        
        // Brand
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        
        // Price - Excection is done in base class
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new Exception("Price cannot be negative!");
                else _price = value;
            }
        }
        
        // Article Number
        public string ArticleNumber
        {
            get => _articleNumber;
            set => _articleNumber = value;
        }
    }
    
    
}