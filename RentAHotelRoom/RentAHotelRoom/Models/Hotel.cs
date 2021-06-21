using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAHotelRoom.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelTotalRooms { get; set; }

        public Hotel()
        {

        }
    }
}
