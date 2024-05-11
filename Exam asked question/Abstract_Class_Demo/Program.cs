namespace myApp
{
    abstract class shape {
        public abstract void area();
       public abstract void show();
        public void peri(int x, int y)
        {
            Console.WriteLine("Peri........");
        }
    }

    class Rectangle : shape {
        int x, y;
        public Rectangle(int x, int y)
        {
            this.x = x; this.y = y; 
        }
        public override void area()
        {
            Console.WriteLine("Area=" + (x * y));
        }
        public override void show()
        {
            Console.WriteLine("Show...........");
        }
    }

    class Program {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 3);
            r.area();
        }
    }



}

