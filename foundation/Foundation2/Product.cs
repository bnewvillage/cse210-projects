using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Product{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;

    public void SetProducts(string name, string id, int price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost(){
        int total = _quantity * _price;
        return total;
    }

    public string ProductSummary(){
        int total = TotalCost();
        string summary = $"|{_name,-10}|{_id,-10}|{_price,-10}|{_quantity,-10}|{total,-10}|\n";
        return summary;
    }
}