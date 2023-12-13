class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        _goalType = "Eternal";
        _goalName = name;
        _description = description;
        _earnedpoints = points;

    }
    public override string GetStringRepresentation()
    {
        string[]goalSum ={_goalType, _goalName, _description, _earnedpoints.ToString()};
        return string.Join("/", goalSum);
    }

}