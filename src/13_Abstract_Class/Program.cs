using System;

namespace _13_Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Book
    {
        protected String title;
        protected  String author;
        
        public Book(String t,String a){
            title=t;
            author=a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        private int _price;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            _price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {_price}");
        }
    }
}
