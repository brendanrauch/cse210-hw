class Program
{
    static void Main(string[] args)

    int x = 10;
    if (x>0)
    {
        console.writeline(x);
    }

    int userage = 0;

    while (userage < 0 || userage > 120)
    {
        Console.writeline("Please input your age(0-120)");
        userage = int.parse(console.readline());

    }

}