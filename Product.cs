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

        private const double min_price = 10;
        private const double max_price = 10000;
        private const int min_stock = 1;
        private const int max_stock = 100000;
        private const int min_id = 10;
        private const int max_id = 100000;



        // Constructor
        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;

        }

        public string ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(ProdName))
                return "Product name can't be empty or null.";

            if (ItemPrice < min_price)
                return $"Item price must be more than {min_price}.";

            if (ItemPrice > max_price)
                return $"Item price must be less than {max_price}.";

            if (StockAmount < min_stock)
                return $"Stock amount must be more than {min_stock}.";

            if (StockAmount > max_stock)
                return $"Stock amount must be less than {max_stock}.";

            if (ProdID < min_id)
                return $"Product ID must be more than {min_id}.";

            if (ProdID > max_id)
                return $"Product ID must be less than {max_id}.";

            return "Product is valid.";
        }

        // increase stock
        public string IncreaseStock(int amount)
        {
            if (amount <= 0)
                return "Amount must be a positive number.";

            if (StockAmount + amount > max_stock)
                return $"Stock amount can't be more than {max_stock}.";

            StockAmount += amount;
            return $"Stock increased by {amount}.";
        }

        //decrease stock
        public void DecreaseStock(int amount)
        {
            if (amount <= 0)
                return "Amount must be a positive number.";

            if (StockAmount - amount < min_stock)
                return $"Stock amount can't be less than {min_stock}.";

            StockAmount -= amount;
            return $"Stock decreased by {amount}.";
        }
    }
}

