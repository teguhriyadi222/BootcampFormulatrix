
namespace Date;


class DateTimeCurrent {

    private DateTime _Datetime;

    public DateTimeCurrent(DateTime datetime) {
        _Datetime = datetime;
    }

    public string CurrentDatetime(){

        return _Datetime.ToString();
    }

    public DateTime AddDays(int days)
    {
        return  _Datetime.AddDays(days);
    }

    public DateTime SubtractDays(int days)
    {
        return _Datetime.AddDays(-days);
    }


    
}

