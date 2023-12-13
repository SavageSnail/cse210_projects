class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool complete)
    {
        _goalType = "Simple";
        _goalName = name;
        _description = description;
        _earnedpoints = points;
        _completed = complete;
    }

    public override string GetStringRepresentation()
    {
        string[]goalSum ={_goalType.ToString(), _goalName, _description, _earnedpoints.ToString(), _completed.ToString()};
        return string.Join("/", goalSum);
    }

}