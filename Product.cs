using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Quality
{
    public class Product
    {
        // Properties
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        // Constructor
        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        // increase stock
        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                StockAmount += amount;
            }
        }

        //decrease stock
        public void DecreaseStock(int amount)
        {
            if (amount > 0 && StockAmount >= amount)
            {
                StockAmount -= amount;

            }
        }
    }
}

