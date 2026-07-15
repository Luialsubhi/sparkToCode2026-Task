using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvaiable;

        public void displayRoom()
        {
            Console.WriteLine("room number  :" + roomNumber);
            Console.WriteLine("room type" + roomType);
            Console.WriteLine("price " + pricePerNight);
            Console.WriteLine("status:" + isAvaiable);
             
        }
    }
}
