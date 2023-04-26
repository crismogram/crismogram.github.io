## Single Responsibility Principle

> A class should have one, and only one, reason to change

> There should never be more than one reason for a class to change

> A module should have a clearly-defined jobs

- Identify "responsibilities" and "jobs"
- Watch out for "reasons to change"
- Favor multiple small classes over fewer, more complex ones.

## Open/Closed Principle

> Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.

> You should be able to extend a class's behavior without modifying it.

- Separate "bedrock" code into base classes
- Implement specializations on top of that bedrock
- Watch for classes with multiple "modes"
- Break these into smaller classes

## Liskov Substitution Principle

> Derive types must be substitutable for their base types."

- Test subtypes individually
- Test that they each perform all tasks
- Watch out for NotImplementedExceptions

## Interface Segregation Principle

> Clients should not be forced to depend upon interfaces that they do not use

> Make fine-grained interfaces that are client-specific

- Create interfaces for a class's abilities
- Group related functionality together
- Keep interfaces cohesive

## Dependency Inversion Principle

> High-level modules should not depend on low-level modules. Both should depend on abstractions.

> Depend on abstractions, not concretions.

- Don't instantiate your own dependencies
- Require them as constructors parameters or inject them as properties
- Consider using an IOC container










---
Grubb, M (2023, March) *Object-oriented Design with C# 10* Pluralsight. https://app.pluralsight.com/library/courses/c-sharp-10-object-oriented-design/table-of-contents