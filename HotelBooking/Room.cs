using System;
namespace Hotell
{
    public class Room
    {
        
        public int RoomNR;
        public string Beds;
        private Hotel hotel;//Composit relation to hotel
        private bool occupied = false;

        public Room()
        {
        }

        public Room(Hotel hotel)//Composit relation to hotel
        {
            this.hotel = hotel;
        }

        public bool Occupied
        {
            get
            {
                return occupied;
            }
            set
            {
                occupied = value;
            }
        }


    }
}
