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

        double x1 = 0, x2 = 0;
        if (SolveQuadraticEquation(a, b, c, ref x1, ref x2))
        {
            Console.WriteLine($"The roots are: x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("No real roots found.");
        }
    }

    static bool SolveQuadraticEquation(double a, double b, double c, ref double x1, ref double x2)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return false; // No real roots
        }

        double sqrtDiscriminant = Math.Sqrt(discriminant);
        x1 = (-b + sqrtDiscriminant) / (2 * a);
        x2 = (-b - sqrtDiscriminant) / (2 * a);
        return true;
    }
}
