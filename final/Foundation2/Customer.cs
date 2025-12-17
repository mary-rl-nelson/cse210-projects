using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _address = address;
        _customerName = customerName;
    }
    
    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool InUSA()
    {
        return _address.USACheck();
    }

    public string GetShippingLabel()
    {
        return $"{_customerName}\n Address: {_address.GetFullAddress}";
    }
}