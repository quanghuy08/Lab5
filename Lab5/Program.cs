using System;
using Lab5.Customer;
using Lab5.Order;

namespace Lab5
{
    namespace Customer
    {
        class CustomerName
        {
            public String customerName { get; set; }
        }
    }
    
    namespace Order
    {   class GroceryItems
        {
            public void groceryItems()
            {
                Console.WriteLine("Grocery Items");
            }
        }

        class BakeryProducts
        {
            public void bakeryProducts()
            {
                Console.WriteLine("Bakery Products");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerName customerName = new CustomerName();
            customerName.customerName = "Customer";
            Console.WriteLine(customerName);

            Console.WriteLine("Customer has choice grocery items: ");
            GroceryItems groceryItems = new GroceryItems();
            groceryItems.groceryItems();
        }
    }
}