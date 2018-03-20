using System;

namespace Sports_equipment
{
    /* Derived Class fro SportsItem. It differs only in one field. the reduce.
     * It uses the printItem method from its base class to print */
    public class SaleSports : SportsItem
    {
        private double reduce;


        /* Constructor for the dervied class. Base calls the constructor of the base class with the parameter of them */
        public SaleSports (double reduce, string description, double price, string articleNumber, string brand) 
            : base (description, brand, price, articleNumber)
        {
            /* price get updated to conform the reduction */
            this.Price = (decimal)(price * (1 - reduce / 100));
        }
    }
}