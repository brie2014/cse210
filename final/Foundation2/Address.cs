public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public Boolean IsCountryUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public string GetDetailsString()
    {
        return $@"{_streetAddress}
{_city}, {_stateOrProvince}, {_country}";
    }
}