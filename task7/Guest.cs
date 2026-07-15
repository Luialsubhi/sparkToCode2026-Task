using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDats;
        public int totalNights;

        public void displayGuest()
        {
            Console.WriteLine("Guest Id  :" + guestId);
            Console.WriteLine("Guest name  : "+guestName);
            Console.WriteLine("room number  " + roomNumber);
            Console.WriteLine("total"+totalNights);

        }
        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
        }
    }
}
