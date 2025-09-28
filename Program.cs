
//App for solving Quadratic equations
using _4._4;

static void Menu()
{
    Console.WriteLine("Please Enter a quadratic equation in the format of:");
    Console.WriteLine("1. y=ax^2+bx+c");
    StandardForm Equation = new StandardForm();

    double[] xInts = Equation.ReturnXInts();
    Console.Write("X Intercepts: ");
    foreach (double x in xInts )
    {
        Console.Write($"({x},0)");
    }
    Console.WriteLine();
    Console.Write("Y Intercept: ");
    Console.WriteLine(Equation.ReturnYInt());
    Console.WriteLine("Press Enter to Exit");
    Console.ReadKey();
}



Menu();
