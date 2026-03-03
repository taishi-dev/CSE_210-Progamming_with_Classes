Person person = new Person();
person._givenName = "Joseph";
person._familyName = "Smith";
person.ShowWesternName();
person.ShowEasternName();

Person person1 = new Person();
person1._givenName = "Emma";
person1._familyName = "Smith";
person1.ShowWesternName();

Person person2 = new Person();
person2._givenName = "Joseph";
person2._familyName = "Smith";
person2.ShowWesternName();

Blind kitchen = new Blind();
kitchen._width = 60;
kitchen._height = 48;
kitchen._color = "white";
Console.WriteLine(kitchen._width);


House johnsonHome = new House();
johnsonHome._owner = "Johnson Family";

johnsonHome._kitchen._width = 60;

// johnsonHome._blinds.Add(kitchen);

// double amount = johnsonHome._blinds[0].GetArea();

foreach (Blind b in johnsonHome._blinds)
{
    double amount = b.GetArea();
}
    

// A code template for the category of things known as Person. The
// responsibility of a Person is to hold and display personal information.
public class Person
{
    // The C# convention is to start member variables with an underscore _
    public string _givenName = "";
    public string _familyName = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Person()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}

public class Blind
{
  public double _width;
  public double _height;
  public string _color;

  public double GetArea()
    {
        return _width * _height;
    }
}

public class House
{
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();
}
