using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation ax^2 + bx + c = 0:");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquation equation = new QuadraticEquation(a, b, c);
        equation.Solve();

        if (equation.HasRealRoots)
        {
            Console.WriteLine($"The roots are: x1 = {equation.Roots.Item1}, x2 = {equation.Roots.Item2}");
        }
        else
        {
            Console.WriteLine("No real roots found.");
        }
    }

    class QuadraticEquation
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public (double, double) Roots { get; private set; }
        public bool HasRealRoots { get; private set; }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Solve()
        {
            double discriminant = B * B - 4 * A * C;
            if (discriminant < 0)
            {
                HasRealRoots = false;
                return;
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-B + sqrtDiscriminant) / (2 * A);
            double x2 = (-B - sqrtDiscriminant) / (2 * A);
            Roots = (x1, x2);
            HasRealRoots = true;
        }
    }
}
