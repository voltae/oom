using System;
namespace Sports_equipment
{
    /// <summary>
    /// Price. Binds the price value and the currency unit together.
    /// </summary>
    public struct Price
    {
        // Constructor of the class 
        public Price(decimal amount, Currency unit)
        {
            Amount = amount;
            Unit = unit;

        }

        // Getter for both values
        public decimal Amount
        { get; }

        public Currency Unit
        { get; }


    }


}
