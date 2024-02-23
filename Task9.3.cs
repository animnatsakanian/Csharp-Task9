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

        double[] roots = SolveQuadraticEquation(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots found.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The root is: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The roots are: x1 = {roots[0]}, x2 = {roots[1]}");
        }
    }

    static double[] SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return new double[0]; // No real roots
        }

        double sqrtDiscriminant = Math.Sqrt(discriminant);
        double x1 = (-b + sqrtDiscriminant) / (2 * a);
        double x2 = (-b - sqrtDiscriminant) / (2 * a);
        return new double[] { x1, x2 };
    }
}
