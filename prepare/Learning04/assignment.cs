public class Assignment

{
    protected string _studentName;
    protected string _topic;


    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

    }

    public string GetStudentName()
    {
        return _studentName;
    }



    //public void SetStudentName(string studentName)
    //{
        //_studentName = studentName;
    //}

    public string GetTopic()
    {
        return _topic;
    }

    //public void SetTopic(String topic )
    //{
        //_topic = topic;
    //}

    public String GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
}