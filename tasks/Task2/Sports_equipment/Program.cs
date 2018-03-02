﻿using System;
using System.Dynamic;

namespace Sports_equipment
{

    public class SportsItem
    {
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
                  /*FIXME: Insert Exception catch function in caller */
                
                /* mit value funktioniert die Abfrage, mit Description nicht, warum? */
                 if (value == "") throw new Exception("description must be set!"); 
                /* assign the private field the incoming value */
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
        internal Access is limited to the current assembly.*/
        /** brief: print out Description, Brand and Price */
       internal void printItem()
        {
            Console.WriteLine($"Item - Description: {this.Description}");
            Console.WriteLine($"Item - Brand: {this._brand}");
            Console.WriteLine($"Price Item1: € {this.Price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* referencing first the varaible */
            SportsItem item1;
            SportsItem item2;
            try
            {
               item2 = new SportsItem("", "Adidas", 29.95, "B787 56333");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
                /* initializing correctly, but first output the error message */
                 item2 = new SportsItem("Football", "Adidas", 29.95, "B787 56333");
             
            }
            item1 = new SportsItem("Touren Ski", "Hagan", 295.95, "A45 670087");

            item1.printItem();
            item2.printItem();
            
            /* Change the Price of the Ski */
            item1.updatePrice(195.95);
           
            item1.printItem();
            
            
            

        }
    }
}