namespace SkillsTest;

public class GymHall
{
    private Dictionary<int, Booking> _bookings;
    
    public int ID { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public GymHall(int iD, string name, string address, string phone, string email)
    {
        ID = iD;
        Name = name;
        Address = address;
        Phone = phone;
        Email = email;
        
        _bookings = new Dictionary<int,Booking>();
    }

    public GymHall()
    {
        _bookings = new Dictionary<int, Booking>();
        ID = DateTime.Now.Year;
    }

    public void RegisterBooking(Booking booking)
    {
        if (!_bookings.ContainsKey(booking.ID))
        {
            _bookings.Add(booking.ID, booking);
        }
    }

    public void PrintBookings()
    {
        foreach (Booking booking in _bookings.Values)
        {
            Console.WriteLine(booking);
        }
    }

    public void RemoveBooking(Booking booking)
    {
        if (_bookings.ContainsKey(booking.ID))
        {
            _bookings.Remove(booking.ID);
        }
    }

    public int TotalBookings()
    {
        return _bookings.Count;
    }
    


    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Address: {Address} Phone: {Phone} E-mail: {Email} Booking Count: {TotalBookings()}";
    }
}