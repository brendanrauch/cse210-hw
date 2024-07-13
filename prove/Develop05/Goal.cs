abstract class Goal
{
    public string _name;
    public string _details;
    public int _points;
    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
}