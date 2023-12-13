class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new(1, "sticker book", 19.99, 5);
        Product product2 = new(2, "beanie with flashlight", 8.89, 3);
        Product product3 = new(3, "orange dog toy", 7.39, 2);
        Product product4 = new(4, "hiking boots", 59.99, 1);
        Product product5 = new(5, "baked lays chips", 3.50, 6);

        // Create customers
        Customer customer1 = new("Jane Doe", "1234 Hill Street", "Mountain View", "UT", "USA");
        Customer customer2 = new("John Doe", "4321 Valley Street", "Valley View", "UT", "USA");

        // Create orders and add products
        Order order1 = new();
        order1.SetCustomer(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        Order order2 = new();
        order2.SetCustomer(customer2);
        order2.AddProduct(product5);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Put orders in a list
        var orders = new List<Order>() { order1, order2 };

        // Display information about each order        
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetTotalCost());
            order.ShowPackingLabel();
            Console.WriteLine();
            order.ShowShippingLabel();
            Console.WriteLine();
        }
    }
}