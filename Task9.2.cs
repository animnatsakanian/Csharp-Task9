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

        (bool hasRealRoots, double x1, double x2) = SolveQuadraticEquation(a, b, c);

        if (hasRealRoots)
        {
            Console.WriteLine($"The roots are: x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("No real roots found.");
        }
    }

    static (bool hasRealRoots, double x1, double x2) SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return (false, 0, 0); // No real roots
        }

        double sqrtDiscriminant = Math.Sqrt(discriminant);
        double x1 = (-b + sqrtDiscriminant) / (2 * a);
        double x2 = (-b - sqrtDiscriminant) / (2 * a);
        return (true, x1, x2);
    }
}

