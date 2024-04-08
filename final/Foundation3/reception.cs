public class Receptions : Event
{
    private string _emailForRSVP;
    private string _registerBeforehand;


    public Receptions(string type, string title, string description, string date, string time,string emailForRSVP, string registerBeforehand) : base(type, title, description, date, time)
    {
        _emailForRSVP = emailForRSVP;
        _registerBeforehand = registerBeforehand;
    }

    public void SetEmailForRSVP(string emailForRSVP)
    {
        _emailForRSVP = emailForRSVP;

    }

    public String GetEmailForRSVP()
    {
        return _emailForRSVP;
    }


    public void SetRegisterBeforehand(string registerBeforehand)
    {
        _registerBeforehand = registerBeforehand;
    }

    public string GetRegisterBeforehand()
    {
        return _registerBeforehand;
    }
 

    public string Reservation()
    {
        return $"Email for RSVP:{_emailForRSVP}, Registration beforehand: {_registerBeforehand}";
    }
}