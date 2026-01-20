using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;
public abstract class Shape
{
    
}
public class Circle : Shape
{
    public int radius;
    public double Perimeter()
    {
        return 6.28*radius;
    }
    public double Area()
    {
       return 3.14*Math.Pow(radius,2);
    }
}
public class Rectangle : Shape
{
    public int length;
    public int width;
    public Rectangle(int l, int w)
    {
        length = l;
        width = w;
    }
    public int Perimeter()
    {
        return length*2+width*2;
    }
    public int Area()
    {
        return length*width;
    }
}
public class Square : Rectangle
{
    public Square(int l) : base(l,l)
    {
        
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Shape[] shapes = new Shape[5];
        shapes[0] = new Rectangle(5,4);
        shapes[1] = new Square(3);
        shapes[2] = new Rectangle(6,3);
        shapes[3] = new Square(5);
        shapes[4] = new Square(10);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(shapes[i].Area());
        }
        Console.WriteLine(shapes);
    }
}