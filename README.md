# PRUEBA TECNICA MEDISMART

# My Service

This is a RESTful service built using C# and the ASP.NET Core framework. It provides a simple API for managing a collection of resources.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- A text editor or IDE of your choice (e.g. Visual Studio, Visual Studio Code)

### Installing

1. Clone or download the repository to your local machine.
2. Open a command prompt or terminal window and navigate to the project's root directory.
3. Run the command `dotnet restore` to restore the project's dependencies.
4. Run the command `dotnet run` to start the service.
5. The service should now be running at `http://localhost:5000/`.

### Endpoints

- `GET /resources`: Retrieves a list of all resources.
- `GET /resources/{id}`: Retrieves the details of a specific resource by ID.
- `POST /resources`: Creates a new resource.
- `PUT /resources/{id}`: Updates an existing resource.
- `DELETE /resources/{id}`: Deletes a resource.

### Example usage

You can test the endpoints using a tool such as [Postman](https://www.postman.com/) or [curl](https://curl.haxx.se/).

- Retrieve a list of resources: `GET http://localhost:5000/resources`
- Retrieve a specific resource: `GET http://localhost:5000/resources/1`
- Create a new resource: `POST http://localhost:5000/resources` with a JSON payload in the request body
- Update an existing resource: `PUT http://localhost:5000/resources/1` with a JSON payload in the request body
- Delete a resource: `DELETE http://localhost:5000/resources/1`

## Built With

- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Additional Resources

- [RESTful API Design](https://restfulapi.net/)
- [Best Practices for Designing a Pragmatic RESTful API](https://www.vinaysahni.com/best-practices-for-a-pragmatic-restful-api)
- [ASP.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/)
