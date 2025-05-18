namespace Decoration.Decorate;

public abstract class Decorator(Component component): Component
{
    public override void Operation()
    {
        component.Operation();
    }
}