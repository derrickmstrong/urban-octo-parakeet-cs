using System;
namespace Refresher
{
    public class Student
    {
        // Attributes
        public string name;
        public string major;
        public double gpa;

        // Constructor
        public Student(string aName, string aMajor, double aGPA)
        {
            name = aName;
            major = aMajor;
            gpa = aGPA;
        }

        // Methods
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
