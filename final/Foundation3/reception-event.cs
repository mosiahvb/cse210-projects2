using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string email)
        : base(title, description, dateTime, address)
    {
        _rsvpEmail = email;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}
