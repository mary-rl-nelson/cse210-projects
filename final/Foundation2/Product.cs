using System;

public class Product
{
    private string _prodName;
    private string _prodId;
    private double _unitPrice;
    private int _quantity;


    public Product(string prodName, string prodId, double unitPrice, int quantity)
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

    public double GetCostTotal()
    {
        return _unitPrice * _quantity;
    }


}