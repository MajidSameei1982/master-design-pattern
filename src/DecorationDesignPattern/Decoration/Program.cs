// See https://aka.ms/new-console-template for more information

using Decoration;
using Decoration.Decorate;

ConcreteComponent component = new ConcreteComponent();

// component.Operation();

ConcreteDecorator concreteDecorator = new ConcreteDecorator(component);

concreteDecorator.Operation();

Console.ReadLine();