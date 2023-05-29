using System;

namespace RiddleMeThis
{
    class Program
    {
        public static int roomNumber = 1;
        static void Main(string[] args)
        {
            KeyChain nyckel = new KeyChain();
            john main = new john();

            main.health--; //just den här karaktären

            nyckel.hasGreenkey = true;

            alltext.FirstRoom();
            alltext.SecoundRoom(main);
            alltext.ThirdRoom();
            alltext.FourthRoom();
            alltext.FifthRoom();
            alltext.Ending();
            while (true) //oändligt loop
            {
                if (roomNumber == 1) alltext.FirstRoom();
                else if (roomNumber == 2) alltext.SecoundRoom(main);
                else if (roomNumber == 3) alltext.ThirdRoom();
                else if (roomNumber == 4) alltext.FourthRoom();
                else if (roomNumber == 5) alltext.FifthRoom();
            }
        }
    }
}
//listor behövs 
//psudo kod