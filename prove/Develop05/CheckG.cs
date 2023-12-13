class CheckListG : Goal
{
    private int _checks;
    private int _bonus;
    private int _limit;
     public CheckListG(string name, string description, int points, int checks, int bonus, int limit)
    {
        _goalType = "CheckList";
        _goalName = name;
        _description = description;
        _earnedpoints = points;
        _checks = checks;
        _bonus = bonus;
        _limit = limit;
    }

    public override string GetStringRepresentation()
    {
        string[]goalSum ={_goalType.ToString(), _goalName, _description, _earnedpoints.ToString(), _checks.ToString(), _bonus.ToString(), _limit.ToString()};
        return string.Join("/", goalSum);
    }

    public override int GetCheck()
    {
        return _checks;
    }

    public override int GetLimit()
    {
        return _limit;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void CompleteGoal()
    {
        if (_checks < _limit)
        {
            _checks ++;
        }
    }

    public override bool IsCompleted()
    {
        if (_checks >= _limit)
        {
            Console.Write("[X] ");
            return true;
        }

        else
        {
            Console.Write("[ ] ");
            return false;
        }
    }
}