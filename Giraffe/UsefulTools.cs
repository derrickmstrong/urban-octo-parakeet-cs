using System;
namespace Refresher
{
    static class UsefulTools // Now that this is a static class you can not create an instance of the class but its good for creating methods and using them with a class
    {
        // Static Method
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}!");
        }
    }
}
