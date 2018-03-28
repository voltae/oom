using System;
using Newtonsoft.Json;

namespace Sports_equipment
{
    public class SportsItem : ItemBase
    {

        /* SportsItem - Constructor */
        public SportsItem(String newDescription, String newArticleNumber, String newBrand, decimal price, Currency currency) :
         this( newDescription,  newArticleNumber,  newBrand, new Price(price, currency))
        {
            Brand = newBrand;
            ArticleNumber = newArticleNumber;

            Description = newDescription;
            /* casting the double to decimal in one single point */
            Price = new Price(price, currency);

        }

        [JsonConstructor]
        public SportsItem(String newDescription, String newArticleNumber, String newBrand, Price price)
        {

            Brand = newBrand;
            ArticleNumber = newArticleNumber;

            Description = newDescription;
            /* casting the double to decimal in one single point */
           
            UpdatePrice(price.Amount, price.Unit);
        }
        /** update Price method
         * 
         */
        public void UpdatePrice(decimal newPrice, Currency currency)
        {
            /* get the new Price and test it against the negative value via getter setter */
            Price = new Price(newPrice, currency);
        }

        /* This method should be only private its only for this file, private is within the same class
        internal Access is limited to the current assembly. internal is the same as file private in swift. */
        /** brief: print out Description, Brand and Price */
        public override void PrintItem()
        {
            // {this.GetType().Name} print the actual class. Uses the ploymorohism

            Console.WriteLine($"{this.GetType().Name} - Description: {this.Description}");
            Console.WriteLine($"{this.GetType().Name} - Brand: {this.Brand}");
            Console.WriteLine($"{this.GetType().Name} - Price Item1: {(Math.Round(this.Price.Amount * 100) / 100)}");
            Console.WriteLine($"{this.GetType().Name}- Currency {Price.Unit}");
            /* this stands for the class itself if item1.printItem() get called - this stands for item1.
             * in case item2.printItem() this stads for item2
             * same as self in swift */
        }
    }
}