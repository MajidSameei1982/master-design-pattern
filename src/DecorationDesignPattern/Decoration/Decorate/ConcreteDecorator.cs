namespace Decoration.Decorate;

public class ConcreteDecorator(Component component) : Decorator(component)
{
    public override void Operation()
    {
        base.Operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("This is write at NewFeature()");
    }
}