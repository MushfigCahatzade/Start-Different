using System;

namespace Project_1._1
{
    internal class Program
    {
        public static bool IsAvailble { get; private set; }

        static void Main(string[] args)
        {
            if (IsAvailble = false)
            {
                Console.WriteLine("Room is Fool");
            }
            else
            {
                IsAvailble = true;
            }


            Console.WriteLine("Bir deyer daxil edin");
            Console.WriteLine("1==Create a room");
            Console.WriteLine("2==Add Room");
            Console.WriteLine("3==Make Reserve");
            Console.WriteLine("4==Show All Rooms");
            Console.WriteLine("0==Exit");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Create a room");
                    break;

                case 2:
                    Console.WriteLine("Add Room");
                    break;
                case 3:
                    Console.WriteLine("Make Reserve");
                    break ;
                    case 4:
                    Console.WriteLine("Show All Rooms");
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
                    default:
                    Console.WriteLine("Melumat yoxdur");
                    break;                   
            }
            

        }
    }
}
