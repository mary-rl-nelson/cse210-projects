using System;

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
        _country = country;
    }

}