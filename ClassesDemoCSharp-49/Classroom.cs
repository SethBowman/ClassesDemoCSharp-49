namespace ClassesDemoCSharp_49;

public class Classroom
{
    //Properties can be of type List or Array
    public List<Person> CodingClass { get; set; } = new List<Person>();
    
    //Method (non static methods for now)
    public void GreetEveryone()
    {
        foreach (var student in CodingClass)
        {
            //Call the method for each student of type Person
            student.Greet();
        }
    }
}