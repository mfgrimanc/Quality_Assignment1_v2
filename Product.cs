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



        // Constructor
        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;

            if (string.IsNullOrWhiteSpace(prodName))
                Console.WriteLine("Product name can't be empty or null.");
    

            if (itemPrice < min_price)
            {
                Console.WriteLine($"Item price must be more than {min_price}");
            }
            else if (itemPrice > max_price) {
                Console.WriteLine($"Item price must be less than {max_price}");
            }
               

            if (stockAmount < min_stock) { 
                Console.WriteLine($"Stock amount must be more than {min_stock}");
            }else if (stockAmount > max_stock)
            {
                Console.WriteLine($"Stock amount must be less than {max_stock}");
            }
        }

        // increase stock
        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                StockAmount += amount;
            }
            else if (amount <= 0) {
                Console.WriteLine("Amount must be a positive number");
            } else if (StockAmount + amount > max_stock)
                Console.WriteLine($"Stock amount cant be more than {max_stock}");
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

