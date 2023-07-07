public abstract class Goal
{
    public string Title;
    public bool IsComplete;

    public Goal(string title)
    {
        Title = title;
        IsComplete = false;
    }

    public abstract int GetPoints();
    public abstract void RecordEvent();
}