using System;

namespace Hotell
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.bookRum();

            RoomKeyCard rk = new RoomKeyCard();
            rk.useKeyCard(hotel);//association relation to hotel
        }
    }
}
