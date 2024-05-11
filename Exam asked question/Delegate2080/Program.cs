namespace MyApplication;
class Program {
    delegate int sum(int a, int b);
    public int add(int a,int b)
    {
        return a + b;
    }
    public static void Main(String[] args) {
        {
            Program p=new Program();
            sum s = new sum(p.add);
            Console.WriteLine(s(2,3));
        } }
}

