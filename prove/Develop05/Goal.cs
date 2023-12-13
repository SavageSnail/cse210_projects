using System.ComponentModel.Design;
using System.Runtime;

abstract class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _description;
    protected int _earnedpoints;
    protected bool _completed;
    

    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _earnedpoints;
    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual bool IsCompleted()
    {
        if (_completed)
        {
            Console.Write("\n[X] ");
            return true;
        }

        else
        {
            Console.Write("\n[ ]");
            return false;
        }

    }

    public virtual void CompleteGoal()
    {
        _completed = true;
    }

    public virtual int GetCheck()
    {
        return 0;
    }

    public virtual int GetLimit()
    {
        return 0;
    }

    public virtual int GetBonus()
    {
        return 0;
    }
}