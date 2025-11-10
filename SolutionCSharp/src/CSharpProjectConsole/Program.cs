// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person p = new Person();
p.Name = "Wesley";
p.Age = 18;
p.Present();

public class Person
{
    public string Name { get; set; }
    public int Age {  get; set; }

    public void Present()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old");
    }
}