using System.Reflection.PortableExecutable;

namespace data {
    class Employee<S>
    {
        S data;
        public Employee(S data)
        {
            this.data = data;
        }
        public void show()
        {
            Console.WriteLine("Data is:"+this.data);
        }
    }
    class Program { 
        public static void Main(string[] args)
        {
            Employee<string> Laxman = new Employee<string>("Laxman");
            Laxman.show();

            Employee<int> id = new Employee<int>(23);
            id.show();

        }
    }

}

