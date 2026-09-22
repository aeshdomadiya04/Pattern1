using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    internal class ProductDetails  // blueprint or template
    {
        // data member
        public string ProductName { get; set; }
        private int ProductId;
        public string Category { get; set; }

    private double Price;

        public void setPrice(double price)
        {
            this.Price = price;
        }

        public double getPrice()
        {
            return this.Price;
        }

        public int ProductID  // property
        {
            get
            {   // read
                return ProductId;
            }
            set  // write
            {
                ProductId = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Product Name:" + ProductName);
            Console.WriteLine("Product ID:" + ProductID);
            Console.WriteLine("Category:" + Category);
            Console.WriteLine("Price:" + Price);
        }
    }

    class Product
    {
        public static void Main(string[] args)
        {
            ProductDetails p1 = new ProductDetails();

            p1.ProductName = "Laptop";
            p1.ProductID = 101;
            p1.Category = "Electronics";
            p1.setPrice(50000);

            p1.Display();

            ProductDetails p2 = new ProductDetails();

            p2.ProductName = "Mobile";
            p2.ProductID = 102;
            p2.Category = "Electronics";
            p2.setPrice(20000);

            p2.Display();

            Console.ReadLine(); 
        }
    }

}
