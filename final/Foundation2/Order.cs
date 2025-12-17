using System;

public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProductToList(Product product)
    {
        _productList.Add(product);
    }

    public decimal GetPriceTotal()
    {
        decimal total = 0;
        foreach (Product p in _productList)
        {
            total = total + p.GetCostTotal();
        }
        if (_customer.InUSA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }

        return total;

    }
}