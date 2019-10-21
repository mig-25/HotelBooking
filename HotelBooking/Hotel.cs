using System;
using System.Collections.Generic;

namespace Hotell
{
    public class Hotel
    {

        public Room room;//Composit relation to room
        public string hotelName;
        public static List<Customer> CustomersList = new List<Customer>();//aggregation relation to Customers

        public static int customerNumberMarker = 1000;
        public static int roomNumberMarker = 100;

        public Hotel(string name)
        {
            hotelName = name;
        }

        public Hotel()//Composit relation to room
        {
            room = new Room(this);
        }

        public Room bookRum()//function with data type of the Room class
        {
            //Create customer
            Customer customer = new Customer();//aggregation relation to Customer
            Console.WriteLine("Enter Customer Name");
            customer.Name = Console.ReadLine();
            customer.CustomerId = ++customerNumberMarker;

            CustomersList.Add(customer);

            foreach (Customer customers in CustomersList)
            {
                Console.WriteLine($"CustomerID Created: {customer.CustomerId} created for Customer name: {customer.Name}");
            }


            //Create room
            Room roomNew = new Room();
            roomNew.RoomNR = ++roomNumberMarker;
            roomNew.Occupied = true;
            Console.WriteLine($"Room nr booked: {roomNew.RoomNR}, Booking status: {roomNew.Occupied}");


            //Console.WriteLine($"Loyalty bonus: {customer.bonus()}");

            return room;
        }

        //public void Key(RoomKeyCard keyCard)
        //{
        //    RoomKeyCard roomKey = new RoomKeyCard();
        //    Console.WriteLine($"Cardnr is {roomKey.CardNr}");

        //    keyCard.useKeyCard(this);
            
        //}


        

    }
}
