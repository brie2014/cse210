public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order()
    {
        _products = new();
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetTotalCost()
    {
        var cost = (double)0;
        foreach (Product product in _products)
        {
            var costToAdd = product.GetPrice();
            cost += costToAdd;
        }
        var shipping = 30;
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }

        return $"SubTotal: ${cost} | Shipping: ${shipping} | Total: ${cost + shipping}";
    }

    public void ShowPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetDetailsString());
        }
    }

    public void ShowShippingLabel()
    {
        Console.WriteLine(_customer.GetDetailsString());
    }
}