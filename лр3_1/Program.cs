using System;

struct Vector
{
    public int x;
    public int y;
    public int z;
    public Vector(int x,int y,int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public double Length => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
    public static Vector operator +(Vector v1,Vector v2)
    {
        return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }
    public static int operator *(Vector v1, Vector v2)
    {
        return v1.x* v2.x + v1.y * v2.y + v1.z * v2.z;
    }
    public static Vector operator *(Vector v1,int fr)
    {
        return new Vector(v1.x * fr, v1.y * fr, v1.z * fr);
    }
    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Length < v2.Length;
    }
    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Length > v2.Length;
    }
    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.Length == v2.Length;
    }
    public static bool operator !=(Vector v1, Vector v2)
    {
        return v1.Length != v2.Length;
    }
}
class Program
    {
        static void Main(string[] args)
        {
        Vector ob1 = new Vector(10,7,4);
        Vector ob2 = new Vector(2, 0, 1);
        Console.WriteLine($"ob1 = {ob1.x} ; {ob1.y} ; {ob1.z} ");
        Console.WriteLine($"ob2 = {ob2.x} ; {ob2.y} ; {ob2.z} ");
        Vector ob3 = ob1 + ob2;
        Console.WriteLine($"ob3= = {ob3.x} ; {ob3.y} ; {ob3.z} ");
        Console.WriteLine($"ob4 = {ob1 * ob2}");
        Vector ob5 = ob1 * 5;
        Console.WriteLine($"ob5= = {ob5.x} ; {ob5.y} ; {ob5.z} ");
        if (ob1 > ob2) Console.WriteLine($"ob1 > ob2");
        if (ob1 < ob2) Console.WriteLine($"ob1 < ob2");
        if (ob1 == ob2) Console.WriteLine($"ob1 == ob2");
    }
    }
