using System;

namespace Sports_equipment
{
    public class SportsItem : ItemBase
    {
    
        
        /* SportsItem - Constructor */
        public SportsItem (String newDescription, String newBrand, double newPrice, String newArticleNumber)
        {
            Brand = newBrand;
            ArticleNumber= newArticleNumber;
            
            Description = newDescription;
            /* casting the double to decimal in one single point */
            Price = (decimal)newPrice;

        }
        
        /** update Price method
         * 
         */
       public void UpdatePrice(double newPrice)
        {
            /* get the new Price and test it against the negative value via getter setter */
            this.Price = (decimal)newPrice;
        }
        
        /* This method should be only private its only for this file, private is within the same class
        internal Access is limited to the current assembly. internal is the same as file private in swift. */
        /** brief: print out Description, Brand and Price */
       public override void printItem()
        {
            Console.WriteLine($"Sport Item - Description: {this.Description}");
            Console.WriteLine($"Sport Item - Brand: {this.Brand}");
            Console.WriteLine($"Sport Item - Price Item1: € {(Math.Round(this.Price * 100) / 100)}");
            /* this stands for the class itself if item1.printItem() get called - this stands for item1.
             * in case item2.printItem() this stads for item2
             * same as self in swift */ 
        }
    }
}