using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAHotelRoom.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int RoomNumber { get; set; }
        public string Ocupide { get; set; }
        public string ClientName { get; set; }
        public string Date { get; set; }

        public HotelRoom()
        {

        }
    }
}
