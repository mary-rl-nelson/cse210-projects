using System;

public class Product
{
    private string _prodName;
    private string _prodId;
    private decimal _unitPrice;
    private int _quantity;


    public Product(string prodName, string prodId, decimal unitPrice, int quantity)
    {
        _prodName = prodName;
        _prodId = prodId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public string GetProdName()
    {
        return _prodName;
    }

    public string GetProdId()
    {
        return _prodId;
    }

    public decimal GetCostTotal()
    {
        return _unitPrice * _quantity;
    }

}