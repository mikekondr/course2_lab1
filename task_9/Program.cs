namespace task_9;

class Rhombus
{
    private double a, b;

    public Rhombus(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public bool Correct()
    {
        bool result = a > 0 && b > 0;
        return result;
    }

    public double Area()
    {
        return (a * b) / 2;
    }

    public double Side() => Math.Sqrt(a * a + b * b) / 2;

    public void Print() =>
        Console.WriteLine("Ромб із діагоналями: a = {0}, b = {1}", a, b);
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("\t\tРозрахунки ромба\n");
            Console.Write("Перша діагональ a = "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Друга діагональ b = "); double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Rhombus rhombus = new Rhombus(a, b);
            rhombus.Print();

            if (rhombus.Correct() == false)
                Console.WriteLine("Ромб з такими значеннями діагоналей - не існує!");
            else
            {
                Console.WriteLine("Площа ромба: {0:f3}", rhombus.Area());
                Console.WriteLine("Довжина сторони ромба: {0:f3}", rhombus.Side());
            }
        }
        catch
        {
            Console.WriteLine("Помилка!");
        }
    }
}

