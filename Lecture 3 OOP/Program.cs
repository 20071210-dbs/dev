using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;
public class Shape
{
    
}
public class Circle : Shape
{
    public static double radius;
    public static double Perimeter()
    {
        return 6.28*radius;
    }
    public static double Area()
    {
        return 3.14*radius^2;
    }
}
public class Rectangle : Shape
{
    public static int length;
    public static int width;
    public static int Perimeter()
    {
        return length*2+width*2;
    }
    public static int Area()
    {
        return length*width;
    }
}
public class Square : Rectangle
{
    public static int Perimeter()
    {
        return length*4;
    }
    public static int Area()
    {
        return length^2;
    }
}