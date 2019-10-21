using System;

namespace Hotell
{
    public class Customer
    {
        public string Name;
        public int CustomerId;
        public int CustomerBonusPoints;//not in use yet
        

        public Customer()
        {
        }

        public Customer(string cn, int sid)
        {
            Name = cn;
            CustomerId = sid;
        }

        public Customer(string name)
        {
            Name = name;
        }

        /*
         Create method if customerID has a room, add bonus
         if(room.occupied == true)
         */

        //public static void Bonus()
        //{

        //    int cbp;

        //    cbp = CustomerBonusPoints;
        //    LoyaltyCard points = new LoyaltyCard();
        //    points.bonusPoints(cbp);
        //}


    }
}
