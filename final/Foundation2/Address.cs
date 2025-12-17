using System;
using System.Security.Cryptography;

public class Address
{
    private string _streetName;
    private string _city;
    private string _state;
    private int _zipCode;
    private string _country;

    public Address(string streetName, string city, string state, int zipCode, string country)
    {
        _streetName = streetName;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country.ToLower();
    }

    public string GetStreetName()
    {
        return _streetName;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public int GetZipCode()
    {
        return _zipCode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool USACheck()
    {
        if (_country == "us" || _country == "usa" || _country == "united states" || _country == "united states of america")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{_streetName}\n{_city}, {_state} {_zipCode}\n{_country}";
    }
}