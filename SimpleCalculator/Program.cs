class Program
{
    double x, y, result;
    int op;
    
    public static void Main()
    {
        int op;
        double x, y;
        
        Console.WriteLine("Please choose an operation:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 _ Division");
        op = int.Parse(Console.ReadLine());

        Console.Write("Please enter first digit: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Please enter second digit: ");
        y = double.Parse(Console.ReadLine());
        
        SimpleCalculator calc = new SimpleCalculator(x,y,op);
        calc.Calculate();
        Console.ReadLine();
    }
}


class SimpleCalculator
{
    double x, y, result;
    int op;

    public SimpleCalculator(double x, double y, int op)
    {
        this.x = x;
        this.y = y;
        this.op = op;
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Sub(double x, double y)
    {
        return x - y;
    }

    public static double Mul(double x, double y)
    {
        return x * y;
    }

    public static double Div(double x, double y)
    {
        return x / y;
    }

    public void Calculate()
    {
        switch (op)
        {
            case 1:
            {
                result = Add(x, y);
                Console.WriteLine(result);
                break;
            }
            case 2:
            {
                result = Sub(x, y);
                Console.WriteLine(result);
                break;
            }
            case 3:
            {
                result = Mul(x, y);
                Console.WriteLine(result);
                break;
            }
            case 4:
            {
                if (y == 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    result = Div(x, y);
                    Console.WriteLine(result);
                }

                break;
            }
            default:
            {
                Console.WriteLine("Invalid input.");
                break;
            }
        }
    }
}