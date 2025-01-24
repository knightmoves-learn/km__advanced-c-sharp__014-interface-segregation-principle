# 013 Service Lifetimes

## Lecture

[![# Service Lifetimes](https://img.youtube.com/vi/Hv63d-GBed/0.jpg)](https://www.youtube.com/watch?v=Hv63d-GBed)

## Instructions

In `HomeEnergyApi/Program.cs`
- Replace the ilne `builder.Services.AddSingleton<IControllerFactory, ApplicationFactory>()` with `builder.Services.AddSingleton<IRepository<int, Home>, HomeRepository>();`.

Delete the file `HomeEnergyApi/ApplicationFactory.cs`

## Building toward CSTA Standards:

- Decompose problems into smaller components through systematic analysis, using constructs such as procedures, modules, and/or objects. (3A-AP-17) https://www.csteachers.org/page/standards
- Construct solutions to problems using student-created components, such as procedures, modules and/or objects. (3B-AP-14) https://www.csteachers.org/page/standards
- Compare levels of abstraction and interactions between application software, system software, and hardware layers. (3A-CS-02) https://www.csteachers.org/page/standards
- Demonstrate code reuse by creating programming solutions using libraries and APIs. (3B-AP-16) https://www.csteachers.org/page/standards

## Resources

- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0#service-lifetimes
- https://en.wikipedia.org/wiki/Inversion_of_control

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
