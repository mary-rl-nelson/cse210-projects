using System;

public class Address
{
    private int _houseNumber;
    private string _streetName;
    private string _city;
    private string _state;
    private int _zipCode;

    public Address(int houseNumber, string streetName, string city, string state, int zipcode)
    {
        _houseNumber = houseNumber;
        _streetName = streetName;
        _city = city;
        _state = state;
        _zipCode = zipcode;
    }

    public string GetAddressLayout()
    {
        return $"{_houseNumber} {_streetName}\n{_city}, {_state} {_zipCode}";
    }
}