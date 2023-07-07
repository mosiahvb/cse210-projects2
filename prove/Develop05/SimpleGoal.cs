public class SimpleGoal : Goal
{
    private int points;

    public SimpleGoal(string title, int points) : base(title)
    {
        this.points = points;
    }

    public override int GetPoints()
    {
        return points;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }
}
