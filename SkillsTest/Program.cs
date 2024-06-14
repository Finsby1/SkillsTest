namespace SkillsTest;

class Program
{
    static void Main(string[] args)
    { 
        //Opgave 2
        Booking booking1 = new Booking(1, new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0),
            15);
        Booking booking2 = new Booking(2, new DateTime(2024, 6, 22, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0),
            16);
        Console.WriteLine(booking1);
        Console.WriteLine(booking2);

        //Opgave 3
        GymHall gh1 = new GymHall(3, "Hal 1", "xdd123", "12345678", "test@test.dk");
        GymHall gh2 = new GymHall(4, "Hal 2", "xdd124", "12345678", "test@test.dk");
        Console.WriteLine(gh1);
        Console.WriteLine(gh2);
        
        //Opgave 4
        GymHall bookingList = new GymHall();
        
        bookingList.RegisterBooking(booking1);
        bookingList.RegisterBooking(booking2);
        bookingList.PrintBookings();
        Console.WriteLine();
        
        bookingList.RemoveBooking(booking2);
        bookingList.PrintBookings();
        Console.WriteLine();
        
        //Opgave 6
        Booking booking3 = new Booking(5, new DateTime(2024, 6, 15, 13, 0, 0), new DateTime(2024, 6, 15, 16, 0, 0), 21);
        Console.WriteLine(booking3);
    }
}