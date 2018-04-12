using System;

namespace Sports_equipment
{
    /* Derived Class fro SportsItem. It differs only in one field. the reduce.
     * It uses the printItem method from its base class to print */
    public class SaleSports : SportsItem


    {
        /* Constructor for the dervied class. Base calls the constructor of the base class with the parameter of them */
        public SaleSports (double reduce, string description, string articleNumber, string brand, decimal priceDez, Currency currency) 
            : base (description, articleNumber, brand, priceDez, currency)
        {
            /* price get updated to conform the reduction */
            Price = new Price (priceDez * (1 - (decimal)reduce / 100), currency);
        }
    }
}