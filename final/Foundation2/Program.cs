using System;

public class Program
{
    public static void Main()
    {
        var address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        var address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        var address3 = new Address("Nv. Trujillo 254", "Trujilo", "LL", "Peru");

        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);
        var customer3 = new Customer("Eduardo Calle", address3);

        var product1 = new Product("Laptop", "A123", 1599.90m, 1);
        var product2 = new Product("Mouse", "B456", 27.59m, 2);
        var product3 = new Product("Keyboard", "C789", 79.90m, 1);

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        var order2 = new Order(customer2);
        order2.AddProduct(product1);

        var order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
        DisplayOrderDetails(order3);
    }
    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        decimal shippingCost;
        decimal totalCost = order.CalculateTotalCost(out shippingCost);
        Console.WriteLine($"Shipping Cost: ${shippingCost}");
        Console.WriteLine($"Total Cost: ${totalCost}\n");
    }
    
}

