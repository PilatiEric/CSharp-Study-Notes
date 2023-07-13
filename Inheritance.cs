//Inheritance



//Inheritance and the Object Class
//The object class is the base class of everything
//Everything it defines exists in every other object ever created

object thing = new object();

//The .ToString() method creates a string representation of any object
//The default is to display the full name of the object's type
Console.WriteLine(thing.ToString());  //Displays "System.Object"

//The Equals() method returns a bool that indicates whether two things are considered equal or not
object a = new object();
object b = a;
object c = new object();
Console.WriteLine(a.Equals(b)); //Displays True
Console.WriteLine(a.Equals(c)); //Displays False






GameObject[] gameObjects = new GameObject[]
{
    new Asteroid(),
    new Asteroid(),
    new Asteroid(),
    new Bullet(),
    new Ship()
};

foreach (GameObject item in gameObjects)
    item.Update();





//Choosing Base Classes

public class Point
{
    public float X { get; set; }
    public float Y { get; set; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

public class GameObject
{
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }

    public GameObject()
    {
        PositionX = 2;
        PositionY = 4;
    }
}

//Designate a base class for another class by putting the name of the class after a colon
public class Asteroid : GameObject
{
    public float Size { get; }
    public float RotationalAngle { get;}

    public Asteroid()
    {
        RotationalAngle = -1;
    }
}


public class Bullet : GameObject
{
    public float Damage { get; }
}

public class Ship : GameObject
{
    public float Durability { get; set; }
}
