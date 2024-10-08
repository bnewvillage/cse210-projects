using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public void SetCurrentCustomer(string name, string street, string city, string state, string country){
        _customer.SetCustomer(name, street, city, state, country);

    }

    public void AddToCart(string name, string id, int price, int quantity){
        Product product = new Product();
        product.SetProducts(name, id, price, quantity);
        _products.Add(product);
    }

    public int TotalOrder(){
        int totalCost = 0;
        foreach (Product product in _products){
            totalCost = totalCost + product.TotalCost();
        }
        return totalCost;
    }

    public int ShippingCost(){
        int shipping;
        if (_customer.GetShipping() == true){
            shipping = 5;
        }
        else{
            shipping = 35;
        }
        return shipping;
    }

    public int TotalWithShipping(){
        int total = ShippingCost() + TotalOrder();
        return total;
    }

    public string PackingLabel(){
        string packinglist = $"|{"Product",-10}|{"ID",-10}|{"Price",-10}|{"Quantity",-10}|{"Subtotal",-10}|\n";
        foreach(Product product in _products){
            packinglist = packinglist + product.ProductSummary();
        }
        packinglist = packinglist + $"|{"",-10}|{"",-10}|{"",-10}|{"Shipping:",-10}|{ShippingCost(),-10}|\n";
        packinglist = packinglist + $"|{"",-10}|{"",-10}|{"",-10}|{"Total:",-10}|{TotalWithShipping(),-10}|\n";
        return packinglist;
    }

    public string ShippingLabel(){
        Address address = _customer.GetAddress();
        string shippingAddress = address.GetAddress();
        string shippingLabel = _customer.GetName() + "\n" + shippingAddress;
        return shippingLabel;
    } 

}

