using System;

class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private DateTime _eventDateTime;
    private Address _eventAddress;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDateTime = dateTime;
        _eventAddress = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDateTime.ToShortDateString()}\nTime: {_eventDateTime.ToShortTimeString()}\nAddress: {_eventAddress.GetAddress()}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_eventTitle}\nDate: {_eventDateTime.ToShortDateString()}";
    }
}
