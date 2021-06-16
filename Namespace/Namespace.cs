
using System;
using Customer;
using Order;

namespace Customer
{
    class Cust_details
    {
        public string strName;

        public void getName()
        {
            Console.WriteLine("Enter your name : ");
            strName = Console.ReadLine();
        }
    }
}

namespace Order
{
    class Grocery_items
    {
        public void Ord_grocery()
        {
            Cust_details objCustDetails = new Cust_details();
            objCustDetails.getName();
            Console.WriteLine("Hello {0}", objCustDetails.strName);
            Console.WriteLine("You have ordered bakery items");
        }
    }

    class Bakery_items
    {
        public void Ord_bakery()
        {
            Cust_details objCust2 = new Cust_details();
            objCust2.getName();
            Console.WriteLine("Hello {0}", objCust2.strName);
            Console.WriteLine("You have ordered bakery items");
        }
    }
}

class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("What would you like to order ? 1-Grocery Items, 2-Bakery Items");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Grocery_items objGrocery = new Grocery_items();
            objGrocery.Ord_grocery();
        }
        else
        {
            if (choice == "2")
            {
                Bakery_items Bakery_items = new Bakery_items();
                Bakery_items.Ord_bakery();
            }
            else
            {
                Console.WriteLine("Enter either 1 or 2 ");
            }
        }

        Console.ReadLine();
    }
}