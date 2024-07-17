using ClassesDemoCSharp_49;

var csharp49 = new Classroom();

//Dot notation
var seth = new Person();
seth.Name = "Seth";
seth.Age = 30;
seth.clothes = "t shirt and slacks";
seth.wallet = 500;

csharp49.CodingClass.Add(seth);

//Object initializer syntax
var mack = new Person()
{
    Name = "Mack",
    Age = 25,
    clothes = "t shirt",
    wallet = 500
};

csharp49.CodingClass.Add(mack);

//Using a custom constructor
var cruz = new Person("Cruz", 32);

csharp49.CodingClass.Add(cruz);

csharp49.GreetEveryone();
