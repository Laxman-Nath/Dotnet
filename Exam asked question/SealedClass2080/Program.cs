namespace MyApplication
{
    sealed class Student {
        public int Id { get; set; }
        public Student(int id)
        {
            this.Id = id;
        }
        public void show()
        {
            Console.WriteLine("Id is :" +this.Id );
        }
    }
    //class Employee : Student { }

    class Program {
        public static void Main(string[] args)
        {
            Student s=new Student(1);
            s.show();
        }
    }


}

