class Product
{
    public string _name { get; set; }
    public string _productId { get; set; }
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }
}
