using System;
namespace Hotell
{
    public class RoomKeyCard
    {
        public int cardNr= 0;

        public RoomKeyCard(int cnr)
        {
            cardNr = cnr;
        }

        public RoomKeyCard()
        {
        }

    public int CardNr
        {
            get
            {
                return cardNr;
            }
        }

        

        public void useKeyCard(Hotel hotel)//Assocition relation to hotel
        {
            cardNr += 1;
            Console.WriteLine($"Cardnr is {CardNr}");
        }
    }
}
