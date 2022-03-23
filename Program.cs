using System;

namespace Tugas_ClassObject_4352_Reksa_Panduasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek taxi
            Taxi taxi = new Taxi();

            //Pengesetan Nilai Properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //Pemanggilan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
