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
        private Price m_price;
        private String _articleNumber;


        // virtual method 
        public virtual void PrintItem()
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
        
        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>The brand.</value>
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public Price Price {
            get { return m_price; }

            set { updatePrice(value.Amount, value.Unit); }
        }
        
        // Price - Excection is done in base class
        public void updatePrice (decimal amount, Currency unit)
        {
            {
                if (amount < 0) throw new Exception("Price cannot be negative!");
                m_price = new Price(amount, unit);
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