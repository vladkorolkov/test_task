using System;

namespace AreaCalculation;
public static class CircleArea
{
    const double PI = Math.PI;
    private static double Operation(double r)
    {
        double S = PI * Math.Pow(r, 2);              
        return S;
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
