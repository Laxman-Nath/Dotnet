namespace MyApplication
{
    class Program {
        delegate int sum(int i, int j);
        public static void Main(string[] args) {
            sum add = (a, b) => a + b;
            Console.WriteLine("The sum is:"+add(2,3));
        }
    }

}

