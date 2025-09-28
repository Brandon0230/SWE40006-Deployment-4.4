
namespace _4._4
{
    public class StandardForm
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public StandardForm()
        {
            A= Calculate('a');
            B = Calculate('b');
            C = Calculate('c');
        }
        public double Calculate(char letter)
        {
            if (C != 0)
            {
                Console.WriteLine($"1. y={A}x^2+{B}x+{C}");
            }
            else if (B != 0)
            {
                Console.WriteLine($"1. y={A}x^2+{B}x+c");
            }
            else if (A != 0) {
                    Console.WriteLine($"1. y={A}x^2+bx+c");
            }
            bool gotValue = false;
            double letterVal = 0;
                while (!gotValue)
                {
                    Console.WriteLine($"Please Enter {letter} value: ");
                    var aUnknownType = Console.ReadLine();
                    if (!(double.TryParse(aUnknownType, out letterVal)))
                    {
                        Console.WriteLine("Error: Please Enter a double value. Press Enter to Continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        gotValue = true;
                    }
                    Console.Clear();
                }
                return letterVal;
            }
        public double[]  ReturnXInts()
        {
            double[] xCoordinates = new double[2];
            double discriminant = (B * B) - 4 * A * C;
            if (discriminant < 0)
            {
                Console.WriteLine("No Real X int. All Complex Values.");
            }
            double xInt1 = (-B + Math.Sqrt(discriminant))/(2 * A);
            double xInt2 = (-B - Math.Sqrt((B * B) - 4 * A * C))/(2 * A);
            xCoordinates[0] = xInt1;
            xCoordinates[1] = xInt2;
            return xCoordinates;
        }
        public double ReturnYInt()
        {
            return C;
        }

    }
}
