namespace SkillsTest;

public class Booking
{
    public int ID { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public int Participants { get; set; }
    

    public Booking(int iD, DateTime start, DateTime end, int participants)
    {
        ID = iD;
        Start = start;
        End = end;
        Participants = participants;
    }

    public bool BookingDurationOK() 
    {
        if (Start.AddHours(2) >= End)
        {
            return true;
        }
        return false;
    }

    public bool IsSundayBooking()
    {
        if (Start.DayOfWeek == DayOfWeek.Sunday)
        {
            return true;
        }
        return false;
    }
    

    public override string ToString()
    {
        return $"ID: {ID}, Start: {Start}, End: {End}, Number of participants: {Participants} Booking confirmation: {BookingDurationOK()} Is it Sunday?: {IsSundayBooking()}";
    }
}