using System;

class Program
{
    static void Main()
    {
        var square1 = new Square(23.45);
        var square2 = new Square(23);
        var square3 = new Square(19);
        var square4 = new Square(82);

        var rectangle = new Rectangle(12,15);

        rectangle.PrintResults();

    }
}