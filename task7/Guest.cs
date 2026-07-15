using System;

namespace HotelManagementSystem
{
    class Guest
    {
        public string guestId { get; set; }
        public string guestName { get; set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }
        public double roomPrice { get; set; }

        public Guest(string guestId, string guestName, string roomNumber,
                     string checkInDate, int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
            roomPrice = 0;
        }

        public double calculateTotalCost()
        {
            return roomPrice * totalNights;
        }

        public void displayGuest()
        {
            Console.WriteLine($"Guest ID    : {guestId}");
            Console.WriteLine($"Guest Name  : {guestName}");
            Console.WriteLine($"Room Number : {roomNumber}");
            Console.WriteLine($"Check In    : {checkInDate}");
            Console.WriteLine($"Nights      : {totalNights}");
            Console.WriteLine("---------------------------------------");
        }
    }
}