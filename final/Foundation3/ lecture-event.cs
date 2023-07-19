using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speakerName, int lectureCapacity)
        : base(title, description, dateTime, address)
    {
        _speaker = speakerName;
        _capacity = lectureCapacity;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
