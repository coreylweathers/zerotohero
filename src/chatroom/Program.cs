using System;

namespace chatroom
{
    public class House
    {
        private int numWindows;
        public int NumWindows 
        {
            get { return numWindows;}
            set 
            { 
                if(value > 0)
                {
                    numWindows = value;
                }
                else if (value <= 0)
                {
                    numWindows = 0;
                }
            }
        }
        public int NumRooms;
        public string Address;

        public void SetAddress()
        {
            Console.Write("Sure we set the address");
            Address = "";

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var house = new House();
            house.NumRooms = 3;
            house.NumWindows = 16;
            house.SetAddress();
        }
    }
}
