class Program
{
        static void Main(string[]args)
    {
        var a = 17;
        var b = 4;

        var qoutient = a / b;

        var remainder = a % b;

        Console.WriteLine($"{a}/{b} is {qoutient} remainder {remainder}");


        AreaOfACircle();


    }

    public static void AreaOfACircle()
    {
        Console.WriteLine("What is the radius of your circle?");

       double radius = double.Parse(Console.ReadLine());

        double pi= Math.PI;

        double area = pi * (radius * radius);

        Console.WriteLine($"The are of a circle with a radius of {radius} is {area}");
    
    
    }







}