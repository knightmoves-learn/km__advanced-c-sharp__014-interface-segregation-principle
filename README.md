# 014 Interface Segregation Principle

## Lecture

[![# Interface Segregation Principle](https://img.youtube.com/vi/qgAZvRFZDIw/0.jpg)](https://www.youtube.com/watch?v=qgAZvRFZDIw)

## Instructions

In `HomeEnergyApi/Models/IReadRepository.cs`
- Create a public interface `IReadRepository<TId, T>`
    - Create a method `List<T> FindAll()`
    - Create a method `T FindById(TId id);`

In `HomeEnergyApi/Models/IWriteRepository.cs`
- Create a public interface `IWriteRepository<TId, T>`
    - Create a method `T Save(T entity)`
    - Create a method `T Update(TId id, T entity)`
    - Create a method `T RemoveById(TId id)`
    - Create a method `int Count()`

In `HomeEnergyApi/Models/HomeRepository.cs`
- Have `HomeRepository` implement the interfaces `IReadRepository<int, Home>` and `IWriteRepository<int, Home>`
    - Create a method `Count()`
        - Should return the current count of `HomesList`

In `HomeEnergyApi/Controllers/HomesAdminController.cs`
- Create a public class `HomesAdminController`...
    - Have `HomesAdminController` implement `ControllerBase`
    - Give `HomesAdminController` attributes...
        - `[ApiController]`
        - `Route("admin/Homes")`
    - Create a private property `repository` of type `IWriteRepository<int, Home>`
    - Create a constructor taking one parameter of type `IWriteRepository<int, Home>`
        - Set the `repository` property ot the value of the passed parameter
    - Create a public `CreateHome()` method containing the same logic currently existing in HomeController.cs for the method with that name
        - You may need to modify the first argument to `Created()` to return the correct location in the HTTP Response headers (ex. a new Home with an id of 1, should return `/Homes/1` as it's location)
    - Create a public `UpdateHome()` method containing the same logic currently existing in HomeController.cs for the method with that name    
    - Create a public `DeleteHome()` method containing the same logic currently existing in HomeController.cs for the method with that name

In `HomeEnergyApi/Controllers/HomesController.cs`
- Remove methods...
    - CreateHome()
    - UpdateHome()
    - DeleteHome()
- Update the type for both the private property `repository` and the argument passed into the constructor to `IReadRepository<int, Home>`

In `HomeEnergyApi/Program.cs`
- Remove the line `builder.Services.AddSingleton<IRepository<int, Home>, HomeRepository>();`.
- Add the lines...
    - `builder.Services.AddSingleton<HomeRepository>();`
    - `builder.Services.AddSingleton<IReadRepository<int, Home>>(provider => provider.GetRequiredService<HomeRepository>());`
    - `builder.Services.AddSingleton<IWriteRepository<int, Home>>(provider => provider.GetRequiredService<HomeRepository>());`

## Building toward CSTA Standards:

- Decompose problems into smaller components through systematic analysis, using constructs such as procedures, modules, and/or objects. (3A-AP-17) https://www.csteachers.org/page/standards
- Construct solutions to problems using student-created components, such as procedures, modules and/or objects. (3B-AP-14) https://www.csteachers.org/page/standards
- Compare levels of abstraction and interactions between application software, system software, and hardware layers. (3A-CS-02) https://www.csteachers.org/page/standards
- Demonstrate code reuse by creating programming solutions using libraries and APIs. (3B-AP-16) https://www.csteachers.org/page/standards

## Resources

- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0#overview-of-dependency-injection
- https://en.wikipedia.org/wiki/Interface_segregation_principle

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
