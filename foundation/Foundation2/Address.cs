public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress(){
        string fullAddress = $"{_street}, {_city}\n{_state}\n{_country}";
        return fullAddress;
    }

    public string GetCountry(){
        return _country;
    }
}