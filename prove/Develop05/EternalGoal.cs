public class EternalGoal : Goal
{
    private int pointsPerEvent;

    public EternalGoal(string title, int pointsPerEvent) : base(title)
    {
        this.pointsPerEvent = pointsPerEvent;
    }

    public override int GetPoints()
    {
        return pointsPerEvent;
    }

    public override void RecordEvent()
    {
        
    }
}
