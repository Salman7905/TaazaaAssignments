using System;
namespace Assignment3.Programs
{
    public interface Drawable  
{  
    void draw();  
}  
public class Rectangle : Drawable  
{  
    public void draw()  
    {  
        Console.WriteLine("drawing rectangle..");
    }  
}  
public class Circle : Drawable  
{  
    public void draw()  
    {  
        Console.WriteLine("drawing circle...");  
    }  
}  

    }
