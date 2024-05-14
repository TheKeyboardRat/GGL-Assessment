# GGL-Assessment

This project is my submission for your dev assessment.
 
I have chosen to use the following technologies for the projects:
### API
- ASP .Net Core 8
- Entity Framework
- Mediatr

The API was done following [Clean Architecture](https://betterprogramming.pub/the-clean-architecture-beginners-guide-e4b7058c1165) with [CQRS and Repository pattern](https://medium.com/@edin.sahbaz/a-demo-on-clean-architecture-with-cqrs-and-repository-pattern-in-net-web-api-986838191e74)

I chose these technologies/patterns because I find them interesting and saw this as a great learning opportunity.

### Client
- React

I chose React because it is something I have not worked with much, I am far more used to standard DHTML. Given React is so widely used now I saw this as a great challenge.


## TODO

- Add game filter ribbon
- Use entity framework for authentication using JWT
- Add more detail to swagger docs
- Update database seeding
- Restructure client
- Add pagination instead of returning all records
- More error handling on API methods
- Unit tests

## Prerequisites

- .Net SDK
- Visual Studio
- Visual Studio Code
- Node.js
- Entity Framework tools
- Postgresql

## How to run

1. locate .sln file in the *Clean-Architecture-Solution* folder
2. Once solution is opened, open terminal and scope to src/infrastructure
3. Run command *dotnet ef database update*
4. Once migration is complete, check that API project is set as startup, ensure debug is set to *http* and run
5. Swagger should open and can be used to run queries
6. To open the client open VS code and open the folder src/react-client
7. Run *NPM start*