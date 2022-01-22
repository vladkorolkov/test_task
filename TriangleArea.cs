using System;
using static System.Math;

namespace AreaCalculation;
public static class TriangleArea
{
    private static double Operation(double first, double second, double third)
    {
        double s = 0;
        double hp = (first + second + third) / 2; //полупериметр
        if (first > 0 && second > 0 && third > 0)
        {
            s = Sqrt(hp * (hp - first) * (hp - second) * (hp - third));
            if (!double.IsNaN(s))
            {
                return Round(s, 2);
            }

        }
        printMessage("Ошибка. Проверьте исходные данные");
        return s;
    }

    private static void IsRightTriangle(double first, double second, double third)
    {
        double hippotenuse = 0;
        double leg1 = 0;
        double leg2 = 0;
        if (first > second && first > third)
        {
            hippotenuse = first;
            leg1 = second;
            leg2 = third;
        }
        if (second > first && second > third)
        {
            hippotenuse = second;
            leg1 = first;
            leg2 = third;
        }
        if (third > first && third > second)
        {
            hippotenuse = third;
            leg1 = first;
            leg2 = second;
        }

        if (Pow(hippotenuse, 2) == Pow(leg1, 2) + Pow(leg2, 2))
        {
            printMessage("Кстати, получившийся треугольник является прямоугольным");
        }
    }

    private static void printMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static double GetTriangleArea(int firstSide, int secondSide, int thirdSide)
    {
        double result = Operation((double)firstSide, (double)secondSide, (double)thirdSide);
        IsRightTriangle((double)firstSide, (double)secondSide, (double)thirdSide);
        return result;
    }

    public static double GetTriangleArea(double firstSide, double secondSide, double thirdSide)
    {
        double result = Operation(firstSide, secondSide, thirdSide);
        IsRightTriangle(firstSide, secondSide, thirdSide);
        return result;
    }
    public static double GetTriangleArea(float firstSide, float secondSide, float thirdSide)
    {
        double result = Operation((double)firstSide, (double)secondSide, (double)thirdSide);
        IsRightTriangle((double)firstSide, (double)secondSide, (double)thirdSide);
        return result;
    }

}