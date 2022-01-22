using System;

namespace AreaCalculation;
public static class CircleArea
{
    const double PI = Math.PI;
    private static double Operation(double r)
    {
        double S = 0;

        if (S > 0)
        {
            S = PI * Math.Pow(r, 2);
        }
        Error("Ошибка.Проверьте исходные данные.");
        return S;
    }

    private static void Error(string message)
    {
        Console.WriteLine(message);
    }
    public static double GetCircleArea(int r)
    {
        double result = Operation((double)r);
        return result;
    }

    public static double GetCircleArea(double r)
    {
        double result = Operation(r);
        return result;
    }
    public static double GetCircleArea(float r)
    {
        double result = Operation((double)r);
        return result;
    }
}