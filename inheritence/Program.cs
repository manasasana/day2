Abstraction
public interface shape
{
    public void draw();
    /*{
        Console.WriteLine("Iam drawing a s");
    }*/
    public void drawing()
    {
        Console.WriteLine("iam drawing a shape");
    }

}
public class square : shape
{
    public void draw()
    {
        Console.WriteLine("Iam drawing a square");
    }
}
public class circle : shape
{
    public void draw()
    {
        Console.WriteLine("Iam drawing a circle");
    }

}
public class test
{
    public static void Main(String[] args)
    {
        shape s1 = new square();
        shape s2 = new circle();
        s1.drawing();
        s2.draw();
    }
}
public class student
{
    public int studentid { get; set; }
    public string studentname { get; set; }
}
public class test
{
    public static void Main(String[] arg)
    {
        student s = new student();
        s.studentid = 23;
        s.studentname = "sana";
        Console.WriteLine("id" + s.studentid);
        Console.WriteLine("name" + s.studentname);

    }
}
public class Employee
{
    public float salary = 24000;
}
public class softdev : Employee
{
    public int age = 23;
    public float bonus = 12000;
}
public class test
{
    public static void Main(String[] args)
    {
        softdev s = new softdev();
        Console.WriteLine(s.salary);
        Console.WriteLine(s.age);
        Console.WriteLine(s.bonus);
    }
}