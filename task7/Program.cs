using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            // Preloaded Rooms
            rooms.Add(new Room(101, "Single", 20, true));
            rooms.Add(new Room(102, "Single", 25, true));
            rooms.Add(new Room(201, "Double", 35, true));
            rooms.Add(new Room(202, "Double", 40, true));
            rooms.Add(new Room(301, "Suite", 60, true));
            rooms.Add(new Room(302, "Suite", 80, true));

            int choice;

            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine(" GRAND VISTA HOTEL MANAGEMENT SYSTEM");
                Console.WriteLine("======================================");
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

                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Room Number: ");
                        int roomNumber = Convert.ToInt32(Console.ReadLine());

                        if (rooms.Any(r => r.roomNumber == roomNumber))
                        {
                            Console.WriteLine("Room already exists.");
                            break;
                        }

                        Console.Write("Enter Room Type (Single/Double/Suite): ");
                        string roomType = Console.ReadLine();

                        Console.Write("Enter Price Per Night: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        if (roomNumber <= 0 || price <= 0)
                        {
                            Console.WriteLine("Invalid room number or price.");
                            break;
                        }

                        Room newRoom = new Room(roomNumber, roomType, price, true);
                        rooms.Add(newRoom);

                        Console.WriteLine("\nRoom Added Successfully.");
                        Console.WriteLine($"Room Number : {roomNumber}");
                        Console.WriteLine($"Room Type   : {roomType}");
                        Console.WriteLine($"Price       : {price:F2}");
                        Console.WriteLine($"Total Rooms : {rooms.Count}");

                        break;

                    case 2:
                        Console.Write("Enter Guest Name: ");
                        string guestName = Console.ReadLine();

                        Console.Write("Enter Check In Date: ");
                        string checkIn = Console.ReadLine();

                        Console.Write("Enter Total Nights: ");
                        int nights = Convert.ToInt32(Console.ReadLine());

                        if (nights <= 0)
                        {
                            Console.WriteLine("Invalid number of nights.");
                            break;
                        }

                        string guestId = "G" + (guests.Count + 1).ToString("000");

                        Guest newGuest = new Guest(guestId, guestName, "Not Assigned", checkIn, nights);

                        guests.Add(newGuest);

                        Console.WriteLine("\nGuest Registered Successfully.");
                        Console.WriteLine($"Guest ID : {guestId}");
                        Console.WriteLine($"Name     : {guestName}");
                        Console.WriteLine($"Check In : {checkIn}");
                        Console.WriteLine($"Nights   : {nights}");

                        break;

                    case 3:
                        Console.Write("Enter Guest ID: ");
                        string id = Console.ReadLine();

                        Console.Write("Enter Room Number: ");
                        int bookRoom = Convert.ToInt32(Console.ReadLine());

                        Guest guest = guests.FirstOrDefault(g => g.guestId == id);
                        Room room = rooms.FirstOrDefault(r => r.roomNumber == bookRoom);

                        if (guest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        if (room == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        if (!room.isAvailable)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }

                        guest.roomNumber = room.roomNumber.ToString();
                        guest.roomPrice = room.pricePerNight;
                        room.isAvailable = false;

                        Console.WriteLine("\nBooking Successful.");
                        Console.WriteLine($"Guest Name : {guest.guestName}");
                        Console.WriteLine($"Room       : {room.roomNumber}");
                        Console.WriteLine($"Type       : {room.roomType}");
                        Console.WriteLine($"Price      : {room.pricePerNight:F2}");
                        Console.WriteLine($"Nights     : {guest.totalNights}");
                        Console.WriteLine($"Total Cost : {guest.calculateTotalCost():F2} OMR");

                        break;

                    case 4:
                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }

                        Console.WriteLine($"Total Rooms : {rooms.Count}");

                        foreach (Room r in rooms.OrderBy(r => r.roomNumber))
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine($"Room Number : {r.roomNumber}");
                            Console.WriteLine($"Room Type   : {r.roomType}");
                            Console.WriteLine($"Price       : {r.pricePerNight:F2}");
                            Console.WriteLine($"Status      : {(r.isAvailable ? "Available" : "Booked")}");
                        }

                        break;

                    case 5:
                        if (guests.Count == 0)
                        {
                            Console.WriteLine("No guests have been registered yet.");
                            break;
                        }

                        Console.WriteLine($"Total Guests : {guests.Count}");

                        foreach (Guest g in guests.OrderBy(g => g.guestName))
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine($"Guest ID    : {g.guestId}");
                            Console.WriteLine($"Guest Name  : {g.guestName}");
                            Console.WriteLine($"Room Number : {g.roomNumber}");
                            Console.WriteLine($"Check In    : {g.checkInDate}");
                            Console.WriteLine($"Nights      : {g.totalNights}");
                        }

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 10:

                        break;

                    case 11:

                        break;

                    case 12:

                        break;

                    case 13:

                        break;

                    case 14:

                        break;

                    case 15:

                        break;

                    case 0:
                        Console.WriteLine("Thank you for using the system.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}