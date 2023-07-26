



Console.WriteLine("init");

{
    Person person;
    person = new Person();
    person.Name = "Ahmed";
    Console.WriteLine(person.Name);
}


public class Person
{

    public string Name { get; set; }

    public Person()
    {
        Console.WriteLine("This is person Constructor .. ");
    }

    ~ Person()
    {
        Console.WriteLine("This is Person deconstructor");
    }
}