using System;
namespace Refresher
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad.");
        }

        public virtual void MakeSpeciality() // virtual means that any subclass can override the functionality of this method
        {
            Console.WriteLine("The chef speciality is bbq ribs.");
        }
    }
}
