namespace Decoration;

public class ConcreteComponent: Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation() is running");
    }
}