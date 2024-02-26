using System;

// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
// derived class 
class Frog : Animal
{
    public int age;  // accessible from any class
    public string type;  //accessible from derived classes
    public string family;

    public void setAge(int age)
    {
        this.age = age;
    }
    public virtual int getAge()
    {
        return age;
    }
    public void setFamily(string family)
    {
        this.family = family;
    }
    public virtual string getFamily()
    {
        return family;
    }

    // access name through base because it is private
    public override string getName()
    {
        return base.getName();
    }

    // access type directly because it is protected and this is a derived class
    public override string getType()
    {
        return type = "frog";
    }

    public virtual string sound()
    {
        return "ribbit";
    }
}
class Program
{

    static void Main(string[] args)
    {
        // object of the base class Animal
        Animal critter = new Animal();
        critter.setName("Kirby");
        critter.setType("Dog");
        // color is a public field and can be accessed anywhere
        critter.color = "Brown";

        Console.WriteLine("Animal Information...");
        Console.WriteLine($"My name is {critter.getName()}");
        Console.WriteLine($"I am a {critter.getType()}");
        Console.WriteLine($"I am a lovely {critter.color} color");
        Console.WriteLine();

        // object of derived class Dog
        Frog froog = new Frog();
        froog.setName("Jumper");
        froog.setType("Frog");
        // color is a public field and can be accessed anywhere
        froog.color = "green";
        // breed is a public field
        froog.family = "Tree Frog";
        // age is a protected field
        froog.setAge(4);

        Console.WriteLine("Frog Information...");
        Console.WriteLine($"My name is {froog.getName()}");
        Console.WriteLine($"I am a {froog.getType()}");
        Console.WriteLine($"I am a lovely {froog.color} color");
        Console.WriteLine($"I am {froog.getAge()} years old");
        Console.WriteLine($"I like to {froog.sound()}");

        Console.ReadLine(); // pauses end of program display
    }

}
