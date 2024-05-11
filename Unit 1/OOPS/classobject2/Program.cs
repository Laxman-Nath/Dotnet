using System;
namespace classobject{
    class Book{
        private string author=null;
        private string price=null;
        private string title=null;

        // public void setTitle(string title){
        //     this.title=title;
        // }
        // public void setAuthor(string author){
        //     this.author=author;
        // }
        // public void setPrice(string price){
        //     this.price=price;
        // }

        public Book(){
            Console.WriteLine("Default constructor");
        }
        public Book(string title,string author,string price){
            Console.WriteLine("Parameterized constructor:");
            this.title=title;
            this.author=author;
            this.price=price;
        }
        public Book(Book b){
            Console.WriteLine("Copy constructor called:");
            this.title=b.title;
            this.author=b.author;
            this.price=b.price;
        }
        public void display(){
            Console.WriteLine("Book title:"+this.title);
            Console.WriteLine("Book price:"+this.price);
            Console.WriteLine("Book Author:"+this.author);
        }
    }
    class Program{
        public static void Main(string [] args){
            Book b1=new Book();
            b1.display();
            Book b2=new Book("dotnet","laxman","2000");
            b2.display();
            Book b3=new Book(b2);
            b3.display();
            // b.setAuthor("laxman");
            // b.setPrice("100");
            // b.setTitle("Dotnet");
            
        }
    }
}
