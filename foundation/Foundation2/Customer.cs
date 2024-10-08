using System.Reflection.Metadata.Ecma335;

public class Customer{
    private string _name;
    private Address _address;
    private bool _isUSA = false;

    public void SetCustomer(string name, string street, string city, string state, string country){
        _name = name;
        Address address = new Address(street, city, state, country);
        _address = address;
        if (_address.GetCountry() == "United States"){
            _isUSA = true;
        }
    }

    public string GetName(){
        return _name;
    }

    public Address GetAddress(){
        return _address;
    }

    public string GetCountry(){
        return _address.GetCountry();
    }

    public bool GetShipping(){
        return _isUSA;
    }
}