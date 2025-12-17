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
        decimal priceTotal = 0;
        foreach (Product p in _productList)
        {
            priceTotal = priceTotal + p.GetCostTotal();
        }
        if (_customer.InUSA())
        {
            priceTotal = priceTotal + 5;
        }
        else
        {
            priceTotal = priceTotal + 35;
        }

        return priceTotal;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product p in _productList)
        {
            packingLabel += $"{p.GetProdName()} | ID: {p.GetProdId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetShippingLabel()}";
    }
}