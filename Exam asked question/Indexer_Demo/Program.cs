namespace myApp
{
    class demo {
        private string[] name = new string[3];
        public string this[int index] {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }

    }
    class Program { 
        public static void Main(string[] args)
        {
            demo d = new demo();
            d[0] = "Laxman";
            d[1] = "Rohit";
            d[2] = "Bikash";
            //d[3] = "Name";
            Console.WriteLine(d[2]);
        }
    }


}

