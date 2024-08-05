using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           float width;
           float height;

           Console.Write("Nhap chieu cao: ");
           width = float.Parse(Console.ReadLine());

           Console.Write("Nhap chieu dai: ");
           height = float.Parse(Console.ReadLine());

           float area = width * height;
           Console.WriteLine("Dien tich hinh chu nhat: " + area);
        }
    }
}