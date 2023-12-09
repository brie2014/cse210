public class Customer
{
    private string _personName;
    private Address _address;

    public Customer(string personName, string streetAddress, string city, string stateOrProvince, string country)
    {
        _personName = personName;
        _address = new(streetAddress, city, stateOrProvince, country);
    }

    public Boolean LivesInUSA()
    {
        return _address.IsCountryUSA();
    }

    public string GetDetailsString()
    {
        return $@"{_personName}
{_address.GetDetailsString()}";
    }
}