using System;

namespace Tugas_ClassObject_4352_Reksa_Panduasa
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public string OnDutyChoices()
        {
            return OnDuty ? "Yes" : "No";
        }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDutyChoices());
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);          
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} Sedang Mengantar Penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
    }
}
