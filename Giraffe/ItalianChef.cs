using System;
namespace Refresher
{
    public class ItalianChef : Chef
    {
        // Overrides the method from the parent class Chef
        public override void MakeSpeciality() // override means that we are going to override the MakeSpeciality method from the parent Chef class
        {
            Console.WriteLine("The chef speciality is pizza.");
        }

        // Extends functionality
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }
    }
}
