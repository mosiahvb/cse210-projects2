using System;

class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, string street, string city)
    {
    
    }

    public string GetStandardDetails()
    {
    
    }

    public virtual string GetFullDetails()
    {
    
    }

    public string GetShortDescription()
    {
    
    }
}