public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = stateProvince;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}
