using System.Reflection.Metadata.Ecma335;

public class Writing : Assignment
{
    private string _title;

    public Writing (string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        //I didn't know you could use a getter like this, this is a game changer
        string student = GetStudentName();

        return $"{_title} by {student}";
         
    }
}