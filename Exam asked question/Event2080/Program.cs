namespace MyApplication
{
    public delegate void DelEventHandler();
    class MyEventClass {
       public static event DelEventHandler Add;
        public static void Main(string[] args)
        {
            Add += new DelEventHandler(Nepal);
            Add += new DelEventHandler(India);
            Add.Invoke();
            Console.ReadLine();
        }

             static void Nepal()
            {
                Console.WriteLine("nepal................");

            }
            static void India() {
            Console.WriteLine("India...............");
            }
        }
    }



