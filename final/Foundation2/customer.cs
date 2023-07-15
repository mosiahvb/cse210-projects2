class Customer
{
    public string _name { get; set; }
    public Address _address { get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}
