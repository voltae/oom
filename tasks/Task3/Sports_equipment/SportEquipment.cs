using System;

namespace Sports_equipment
{
    public class SportsItem : IPrint
    {
        /* field variables with underscore prefix, to distinguish them from the properties */
        private String _description;
        private String _brand;
        private decimal _price;
        private String _articleNumber;

        /* getter and setter for the values Description */
        public String Description
        {
            get { return _description; }
            set
            {
                /* throw verläßt sofort die Funktion und geht in die drüber liegende Funktion.
                 Wenn die Exception nicht behandelt wird, wandert diese in die nächsthöhere Instanz.*/ 
                 
                /* mit value funktioniert die Abfrage, mit Description nicht, warum? */
                 if (value == "") throw new Exception("description must be set!"); 
                /* assign the private field the incoming value => ("value") stand for the entry on the
                 right side of the assignment */
                _description = value;
            }
        }

        /* Getter and Setter Price */
        public decimal Price
        {
            /* short for the getter method {Price = _price} */
            get => _price;
            set
            {
                if (Price < 0) throw new ArgumentOutOfRangeException("Price must not be negative!");
                _price = value;
            }
        }
        
        /* SportsItem - Constructor */
        public SportsItem (String newDescription, String newBrand, double newPrice, String newArticleNumber)
        {
            _brand = newBrand;
            _articleNumber= newArticleNumber;
            
            Description = newDescription;
            /* casting the double to decimal in one single point */
            Price = (decimal)newPrice;

        }
        
        /** update Price method
         * 
         */
       public void updatePrice(double newPrice)
        {
            /* get the new Price and test it against the negative value via getter setter */
            this.Price = (decimal)newPrice;
        }
        
        /* This method should be only private its only for this file, private is within the same class
        internal Access is limited to the current assembly. internal is the same as file private in swift. */
        /** brief: print out Description, Brand and Price */
       public void printItem()
        {
            Console.WriteLine($"Sport Item - Description: {this.Description}");
            Console.WriteLine($"Sport Item - Brand: {this._brand}");
            Console.WriteLine($"Sport Item - Price Item1: € {this.Price}");
            /* this stands for the class itself if item1.printItem() get called - this stands for item1.
             * in case item2.printItem() this stads for item2
             * same as self in swift */ 
        }
    }
}