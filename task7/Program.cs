using System;
using System.Collections.Generic;
using System.Linq;
using task7;

class Program
{
    static void Main()
    {
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();

        rooms.Add(new Room
        {
            roomNumber = 101,
            roomType = "Single",
            pricePerNight = 25,
            isAvaiable = true
        });

        rooms.Add(new Room
        {
            roomNumber = 102,
            roomType = "Double",
            pricePerNight = 40,
            isAvaiable = true
        });

        rooms.Add(new Room
        {
            roomNumber = 103,
            roomType = "Suite",
            pricePerNight = 75,
            isAvaiable = true
        });

        rooms.Add(new Room
        {
            roomNumber = 104,
            roomType = "Single",
            pricePerNight = 30,
            isAvaiable = true
        });

        rooms.Add(new Room
        {
            roomNumber = 105,
            roomType = "Double",
            pricePerNight = 50,
            isAvaiable = true
        });

        rooms.Add(new Room
        {
            roomNumber = 106,
            roomType = "Suite",
            pricePerNight = 100,
            isAvaiable = true
        });

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");

            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

            }
        }
    }
}