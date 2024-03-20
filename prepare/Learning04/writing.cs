using System.Security.Cryptography.X509Certificates;

public class Writing : Assignment

{
    private string _title;


    public Writing(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    //public Writing(string topic) : base(topic)
    //{

    //}

    //public string GetTitle()
    //{
        //return _title;
    //}

    //public void SetTitle(string title)
    //{
        //_title = title;
    //}





    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        
        return $"{_title} by {_studentName}";
    }
}