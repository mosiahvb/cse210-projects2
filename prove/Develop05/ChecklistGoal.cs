public class ChecklistGoal : Goal
{
    private int pointsPerEvent;
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string title, int pointsPerEvent, int targetCount) : base(title)
    {
        this.pointsPerEvent = pointsPerEvent;
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public override int GetPoints()
    {
        if (completedCount == targetCount)
        {
            return pointsPerEvent + 500;
        }
        else
        {
            return pointsPerEvent;
        }
    }

    public override void RecordEvent()
    {
        completedCount++;
        if (completedCount > targetCount)
        {
            completedCount = targetCount;
        }
        IsComplete = (completedCount == targetCount);
    }
}
