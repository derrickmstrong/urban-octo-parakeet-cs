using System;
namespace Refresher
{
    public class Book
    {
        // Attributes/Template
        public string title;
        public string author;
        public int pages;

        /* 
        Constructor
        A constructor is called everytime an instance of the class is created. It saves time by allowing us to pass in arguments when instanciating an class
        You can have multiple constructors ie:
        public Book() {
        }
        which will allow you to set the attributes values after instanciating the class
        */
        public Book(string aTitle, string aAuthor, int aPages) // a stands for Argument
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
