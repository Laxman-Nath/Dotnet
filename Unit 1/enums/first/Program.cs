using System;
namespace Enums{
    enum DayOfWeeks{
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program{
        public static void Main(string [] args){
            DayOfWeeks today=DayOfWeeks.Saturday;
            DayOfWeeks tommorow=DayOfWeeks.Sunday;
            Console.WriteLine(today);
            Console.WriteLine(tommorow);
        }
    }
}
