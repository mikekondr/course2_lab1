namespace lab1;

public class Triangle
{
    //поля обʼєкта
    double a, b, c;

    //конструктор без параметрів
    public Triangle()
    {
    }

    //конструктор з 3-ма параметрами
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    //метод, що виводить на екран значення полів обʼєкта
    public void Print()
    {
        Console.WriteLine("Трикутник зі сторонами:");
        Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
    }

    //метод для обчислення периметру
    public double Perimetr()
    {
        double p = a + b + c;
        return p;
    }

    //метод для обчислення площі
    public double Sqr()
    {
        double p = this.Perimetr() / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }

    //метод для перевірки існування заданого трикутника
    public bool Correct()
    {
        bool p = false;
        if (a > 0 && b > 0 && c > 0 &&
                a < b + c && b < a + c && c < a + b)
            p = true;
        return p;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double x, y, z;
        try
        {
            //ввести три сторони стрикунтика
            Console.Write("Перша сторона: "); x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Друга сторона: "); y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третя сторона: "); z = Convert.ToDouble(Console.ReadLine());

            //створення обʼєкта
            Triangle t = new Triangle(x, y, z);

            //виклик метода обʼєкта, який виведе на екран значення сторін трикунтика
            //тобто, полів обʼєкта
            t.Print();

            //перевірка коректності трикутника
            if (t.Correct()) //якщо такий трикутник може існувати
            {
                //виклаємо методи обʼєкта і отримуємо значення
                double p = t.Perimetr();
                double s = t.Sqr();

                //вивиодимо результат
                Console.WriteLine("P = {0:f3} S = {1:f3}", p, s);
            }
            else //інакше - такий трикутник не може існувати
                Console.WriteLine("Такий трикутник не існує!");
        }
        catch
        {
            //будь-які інші помилки
            Console.WriteLine("Помилка!");
        }
        Console.ReadKey();
    }
}

