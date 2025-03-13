# BaseballECommerce

## Design
The app is implemented using Onion architecture.  All of the layers interact with each other via defined interfaces as follows:

Domain Layer - BaseballECommerce.Core.Domain \
Service Layer - BaseballECommerce.Core.Services, BaseballECommerce.Core.Services.Abstractions \

Infrastructure Layer \
Presentation Layer - BaseballECommerce.Infrastructure.Presentation, BaseballECommerce.Infrastructure.Persistence \

Using dependency injection which flows towards the core of the "Onion", depending on abstractions aka interfaces and not the implementations, we can transparently switch out the implementation at runtime.
We depend on abstractions at compile time, which gives us strict contracts to work with, and we are provided with implementation at runtime. 
This makes the app easily testable because everything depends on abstractions that can easily be mocked with a mocking library such as Moq.  We can write business logic without concern about any of the implementation details.
If we need anything from an external system or service, we can create an interface for it and consume it.  We do not need to worry about how it will be implemented.

Domain layer is isolated from client as it does NOT have any direct dependencies on the outside layers.  The outer layers are all allowed to reference the layers directly below them in the hierarchy.
Presentation -> Service -> Domain <- Infrastructure

Lower layers of the Onion architecture can be used to define contracts or interfaces, which the outer layers implement.  Encapsulate rich business logic in Domain and Service layers without knowing any implementation details.