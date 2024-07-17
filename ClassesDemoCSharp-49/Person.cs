namespace ClassesDemoCSharp_49;

public class Person
{
    //Fields - a variable inside of class (camel case)
    public int wallet;
    public string clothes;
    
    //Properties - things that define the class (pascal case)
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Methods (non static methods for now)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
    
    //Constructors
    
    //Default constructor
     public Person()
     {
         
     }

    //Custom constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}