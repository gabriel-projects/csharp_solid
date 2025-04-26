# SOLID Principles in C#

SOLID is an acronym for five design principles in object-oriented programming that help make software designs more understandable, flexible, and maintainable. These principles were introduced by Robert C. Martin (Uncle Bob).

## 1. Single Responsibility Principle (SRP)

**Definition**: A class should have only one reason to change, meaning it should have only one job or responsibility.

### ❌ Incorrect Implementation
```csharp
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveUser()
    {
        // Database logic
    }

    public void SendEmail()
    {
        // Email sending logic
    }

    public void ValidateUser()
    {
        // Validation logic
    }
}
```

### ✅ Correct Implementation
```csharp
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserRepository
{
    public void SaveUser(User user)
    {
        // Database logic
    }
}

public class EmailService
{
    public void SendEmail(User user)
    {
        // Email sending logic
    }
}

public class UserValidator
{
    public bool ValidateUser(User user)
    {
        // Validation logic
    }
}
```

## 2. Open/Closed Principle (OCP)

**Definition**: Software entities should be open for extension but closed for modification.

### ❌ Incorrect Implementation
```csharp
public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle)
        {
            var rectangle = (Rectangle)shape;
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle)
        {
            var circle = (Circle)shape;
            return Math.PI * circle.Radius * circle.Radius;
        }
        throw new ArgumentException("Unknown shape");
    }
}
```

### ✅ Correct Implementation
```csharp
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
```

## 3. Liskov Substitution Principle (LSP)

**Definition**: Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.

### ❌ Incorrect Implementation
```csharp
public class Bird
{
    public virtual void Fly()
    {
        // Flying logic
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins can't fly!");
    }
}
```

### ✅ Correct Implementation
```csharp
public abstract class Bird
{
    public abstract void Move();
}

public class FlyingBird : Bird
{
    public override void Move()
    {
        // Flying logic
    }
}

public class Penguin : Bird
{
    public override void Move()
    {
        // Swimming logic
    }
}
```

## 4. Interface Segregation Principle (ISP)

**Definition**: Clients should not be forced to depend on interfaces they do not use.

### ❌ Incorrect Implementation
```csharp
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Robot : IWorker
{
    public void Work()
    {
        // Work logic
    }

    public void Eat()
    {
        throw new NotImplementedException("Robots don't eat!");
    }

    public void Sleep()
    {
        throw new NotImplementedException("Robots don't sleep!");
    }
}
```

### ✅ Correct Implementation
```csharp
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public interface ISleeper
{
    void Sleep();
}

public class Robot : IWorker
{
    public void Work()
    {
        // Work logic
    }
}

public class Human : IWorker, IEater, ISleeper
{
    public void Work()
    {
        // Work logic
    }

    public void Eat()
    {
        // Eating logic
    }

    public void Sleep()
    {
        // Sleeping logic
    }
}
```

## 5. Dependency Inversion Principle (DIP)

**Definition**: High-level modules should not depend on low-level modules. Both should depend on abstractions.

### ❌ Incorrect Implementation
```csharp
public class EmailService
{
    private readonly SmtpClient _smtpClient;

    public EmailService()
    {
        _smtpClient = new SmtpClient();
    }

    public void SendEmail(string to, string message)
    {
        _smtpClient.Send(to, message);
    }
}
```

### ✅ Correct Implementation
```csharp
public interface IEmailSender
{
    void SendEmail(string to, string message);
}

public class SmtpEmailSender : IEmailSender
{
    private readonly SmtpClient _smtpClient;

    public SmtpEmailSender(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public void SendEmail(string to, string message)
    {
        _smtpClient.Send(to, message);
    }
}

public class EmailService
{
    private readonly IEmailSender _emailSender;

    public EmailService(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void SendEmail(string to, string message)
    {
        _emailSender.SendEmail(to, message);
    }
}
```

## Benefits of SOLID Principles

1. **Maintainability**: Code is easier to maintain and modify
2. **Testability**: Easier to write unit tests
3. **Reusability**: Components can be reused in different contexts
4. **Scalability**: Easier to scale and extend the application
5. **Readability**: Code is more organized and easier to understand

## Best Practices

1. Always start with the simplest implementation
2. Refactor when you notice violations of SOLID principles
3. Use dependency injection to manage dependencies
4. Write unit tests to ensure your code follows SOLID principles
5. Keep interfaces small and focused
6. Use composition over inheritance when possible