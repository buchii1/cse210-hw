using System;

class Program
{
    static void Main(string[] args)
    {
        // List of orders
        List<Order> orders = new List<Order>();

        // PRODUCTS
        Product product1 = new Product("Sneakers", 1, 45, 5);
        Product product2 = new Product("Hoddie", 2, 63, 3);
        Product product3 = new Product("JBL Speaker", 3, 236, 8);
        Product product4 = new Product("LG Standing Fan", 4, 122, 2);
        Product product5 = new Product("Thermocool Fridge", 5, 364, 1);
        Product product6 = new Product("Dell XPS 27", 6, 736, 4);

        // ADDRESS OF JOHN DOE
        string street = "No 14 Egbengwu Street Amawbia";
        string city = "Awka";
        string state = "Anambra State";
        string country = "Nigeria";
        Address address1 = new Address(street, city, state, country);

        // ADDRESS OF JANE DOE
        string street1 = "41b Idaho Fals";
        string city1 = "Rexburg";
        string state1 = "Idaho";
        string country1 = "USA";
        Address address2 = new Address(street1, city1, state1, country1);

        // CUSTOMERS
        Customer user1 = new Customer("John Doe", address1);
        Customer user2 = new Customer("Jane Doe", address2);

        // ORDERS OF JOHN DOE
        Order order1 = new Order(user1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order1.AddProduct(product5);

        // ORDERS OF JANE DOE
        Order order2 = new Order(user2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product6);

        // Add orders to the orders list
        orders.Add(order1);
        orders.Add(order2);

        // Loop through the orders list and display order details
        foreach (Order item in orders)
        {
            item.PackingLabel();
            Console.WriteLine();
            item.ShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${item.CalculateOrder().ToString("0.00")}");
            Console.WriteLine("\n");
        }
    }
}