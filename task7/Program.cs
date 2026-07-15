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
                        int option;

                        do
                        {
                            Console.WriteLine("\n===== Search & Filter Rooms =====");
                            Console.WriteLine("1. Show Available Rooms");
                            Console.WriteLine("2. Filter By Room Type");
                            Console.WriteLine("3. Filter By Maximum Price");
                            Console.WriteLine("4. Room Price Statistics");
                            Console.WriteLine("0. Back");

                            Console.Write("Choose: ");
                            option = Convert.ToInt32(Console.ReadLine());

                            switch (option)
                            {
                                case 1:

                                    var availableRooms = rooms
                                        .Where(r => r.isAvailable)
                                        .OrderBy(r => r.pricePerNight);

                                    Console.WriteLine($"Available Rooms: {availableRooms.Count()}");

                                    if (!availableRooms.Any())
                                    {
                                        Console.WriteLine("No rooms found.");
                                    }
                                    else
                                    {
                                        foreach (var r in availableRooms)
                                        {
                                            Console.WriteLine($"{r.roomNumber} - {r.roomType} - {r.pricePerNight:F2}");
                                        }
                                    }

                                    break;

                                case 2:

                                    Console.Write("Enter Room Type: ");
                                    string type = Console.ReadLine();

                                    var roomType6 = rooms
                                        .Where(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                                    Console.WriteLine($"Found: {roomType6.Count()}");

                                    if (!roomType6.Any())
                                    {
                                        Console.WriteLine("No rooms found.");
                                    }
                                    else
                                    {
                                        foreach (var r in roomType6)
                                        {
                                            Console.WriteLine($"{r.roomNumber} - {r.roomType} - {r.pricePerNight:F2}");
                                        }
                                    }

                                    break;

                                case 3:

                                    Console.Write("Maximum Price: ");
                                    double maxPrice = Convert.ToDouble(Console.ReadLine());

                                    var priceRooms = rooms
                                        .Where(r => r.isAvailable && r.pricePerNight <= maxPrice)
                                        .OrderBy(r => r.pricePerNight);

                                    Console.WriteLine($"Found: {priceRooms.Count()}");

                                    if (!priceRooms.Any())
                                    {
                                        Console.WriteLine("No rooms found.");
                                    }
                                    else
                                    {
                                        foreach (var r in priceRooms)
                                        {
                                            Console.WriteLine($"{r.roomNumber} - {r.roomType} - {r.pricePerNight:F2}");
                                        }
                                    }

                                    break;

                                case 4:

                                    Console.WriteLine($"Total Rooms : {rooms.Count()}");
                                    Console.WriteLine($"Available   : {rooms.Count(r => r.isAvailable)}");
                                    Console.WriteLine($"Average     : {rooms.Average(r => r.pricePerNight):F2}");
                                    Console.WriteLine($"Minimum     : {rooms.Min(r => r.pricePerNight):F2}");
                                    Console.WriteLine($"Maximum     : {rooms.Max(r => r.pricePerNight):F2}");

                                    break;
                            }

                        } while (option != 0);


                        break;

                    case 7:
                        Console.WriteLine($"Total Guests : {guests.Count()}");
                        Console.WriteLine($"Booked Guests : {guests.Count(g => g.roomNumber != "Not Assigned")}");

                        Console.WriteLine($"Total Rooms : {rooms.Count()}");
                        Console.WriteLine($"Booked Rooms : {rooms.Count(r => !r.isAvailable)}");

                        if (guests.Any(g => g.roomNumber != "Not Assigned"))
                        {
                            Console.WriteLine($"Average Nights : {guests.Where(g => g.roomNumber != "Not Assigned").Average(g => g.totalNights):F2}");

                            Console.WriteLine("\nTop 3 Guests");

                            foreach (var g in guests
                                .Where(g => g.roomNumber != "Not Assigned")
                                .OrderByDescending(g => g.calculateTotalCost())
                                .Take(3))
                            {
                                Console.WriteLine($"{g.guestName} - Room {g.roomNumber} - {g.calculateTotalCost():F2}");
                            }

                            Console.WriteLine("\nBooking Summary");

                            foreach (var g in guests
                                .Where(g => g.roomNumber != "Not Assigned")
                                .Select(g => $"{g.guestName} - Room {g.roomNumber} - {g.totalNights} Nights - {g.calculateTotalCost():F2} OMR"))
                            {
                                Console.WriteLine(g);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No active bookings recorded.");
                        }


                        break;

                    case 8:
                        Console.Write("Enter Room Number: ");
                        int updateRoom = Convert.ToInt32(Console.ReadLine());

                        Room update = rooms.FirstOrDefault(r => r.roomNumber == updateRoom);

                        if (update == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        Console.Write("New Price: ");
                        double newPrice = Convert.ToDouble(Console.ReadLine());

                        if (newPrice <= 0)
                        {
                            Console.WriteLine("Invalid price.");
                            break;
                        }

                        double oldPrice = update.pricePerNight;
                        update.pricePerNight = newPrice;

                        Console.WriteLine($"Updated Successfully ({oldPrice:F2} -> {newPrice:F2})");

                        break;

                    case 9:
                        Console.Write("Enter Guest Name: ");
                        string search = Console.ReadLine();

                        var result = guests.Where(g =>
                            g.guestName.ToLower().Contains(search.ToLower()));

                        Console.WriteLine($"Matches : {result.Count()}");

                        if (!result.Any())
                        {
                            Console.WriteLine("No guests matched that search.");
                        }
                        else
                        {
                            foreach (var g in result)
                            {
                                Console.WriteLine($"{g.guestId} - {g.guestName} - Room {g.roomNumber}");
                            }
                        }
                        break;

                    case 10:
                        string[] roomTypes = { "Single", "Double", "Suite" };

                        foreach (string t in roomTypes)
                        {
                            int count = rooms.Count(r => r.roomType == t);

                            Console.WriteLine($"\nRoom Type : {t}");
                            Console.WriteLine($"Count : {count}");

                            if (count > 0)
                            {
                                Console.WriteLine($"Average Price : {rooms.Where(r => r.roomType == t).Average(r => r.pricePerNight):F2}");
                            }
                            else
                            {
                                Console.WriteLine("Average Price : N/A");
                            }
                        }

                        Console.WriteLine($"\nOverall Average : {rooms.Average(r => r.pricePerNight):F2}");

                        break;

                    case 11:
                        Console.Write("Enter Guest ID: ");
                        string checkId = Console.ReadLine();

                        Guest checkGuest = guests.FirstOrDefault(g => g.guestId == checkId);

                        if (checkGuest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        if (checkGuest.roomNumber == "Not Assigned")
                        {
                            Console.WriteLine("This guest has no active booking.");
                            break;
                        }

                        Room checkRoom = rooms.FirstOrDefault(r => r.roomNumber.ToString() == checkGuest.roomNumber);

                        Console.WriteLine($"\nGuest : {checkGuest.guestName}");
                        Console.WriteLine($"Room : {checkGuest.roomNumber}");
                        Console.WriteLine($"Type : {checkRoom.roomType}");
                        Console.WriteLine($"Check In : {checkGuest.checkInDate}");
                        Console.WriteLine($"Nights : {checkGuest.totalNights}");
                        Console.WriteLine($"Price : {checkRoom.pricePerNight:F2}");
                        Console.WriteLine($"Total : {checkGuest.calculateTotalCost():F2}");

                        Console.Write("\nConfirm Checkout (Y/N): ");
                        string confirm = Console.ReadLine();

                        if (confirm.ToUpper() == "Y")
                        {
                            checkRoom.isAvailable = true;
                            guests.Remove(checkGuest);

                            Console.WriteLine("Checkout Completed.");
                            Console.WriteLine($"Guests : {guests.Count}");
                            Console.WriteLine($"Rooms : {rooms.Count}");
                        }

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