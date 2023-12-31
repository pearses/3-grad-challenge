# CRUD RestAPI Extension Software Engineering Challenge

### Using the instance

```
Check sqlcmd version
/opt/mssql-tools/bin/sqlcmd "-?"
Login to Database
/opt/mssql-tools/bin/sqlcmd -S db -U SA -P P@ssw0rd
```


## Introduction

In this software engineering challenge builds upon challenges 1 and 2. This time you are going to complete the same requirements of challenge 2 for dotnet 7 with an mssql database using dependency injection with a devcontainter.

Primary purpose is to simulate client tasking with changing needs.
If you follow the DI mock recommendation in the real world where complex external dependencies exist (for this challenge the database) you can get your tasks 80-90% complete. At this point you can follow tutorials and read the docs to try an interface with the complex external dependency, however if you can't it is time to reachout to a senior. However, at this point you largely have complete your tasking.

## Requirements

1. Using dotnet 7 and mssql achieve the required functionality of challenges 01-02/23.

- Choose a single database table to work with. The table should have at least the following fields:
   - `id` (unique identifier for each record)
   - `name` (string, representing the name of an item)
   - `description` (string, providing additional information about the item)
   - You can add more fields if you wish, but the above three are mandatory.

- Implement the following endpoints:

   - **Create** (HTTP POST):
     - Endpoint: `/items`
     - Description: Allows the user to create a new item by providing the `name` and `description` in the request body.
     - Response: Returns the created item with its unique `id`.

   - **Read** (HTTP GET):
     - Endpoint: `/items/:id`
     - Description: Retrieves the details of a specific item by providing its unique `id`.
     - Response: Returns the item's details (including `name`, `description`, and `id`) if it exists, or an appropriate error message if not found.

   - **Update** (HTTP PUT or PATCH):
     - Endpoint: `/items/:id`
     - Description: Allows the user to update an existing item's `name` and/or `description` by providing the updated values in the request body. The `id` should remain unchanged.
     - Response: Returns the updated item.

   - **Delete** (HTTP DELETE):
     - Endpoint: `/items/:id`
     - Description: Deletes an item with the provided `id`.
     - Response: Returns a success message or an appropriate error message if the item doesn't exist.

- Use swagger to explain and demo how to use your RestAPI, including the endpoints, expected request and response formats, and any additional details.

2. Use vscode to create an appropriate devcontainer (tutorials exist within VSCODE docs). 

3. Refactor the code to implement an interface for the service and dao layer

4. Implement a mocked service and dao using interface dependency injection

5. Test the mocked service implementation returns the mocked response

6. Implement the real Service using the interface to using the dao mocked implementation

6. Implement the real dao and test switching the primary annotation between the dao mock and real implementation

## Submission

Once you complete the challenge, create a public GitHub repository and upload your code, along with the documentation, to the repository. Share the repository link with the team.

## Evaluation

Your submission will be evaluated based on the following criteria:

- Usage of devcontainer by git submodule
- Usage and demonstrated control of Interface DI in springboot


Notes:
- CODE FIRST APPROACH
- Make sure to plug in database at the end (just output to text file for now)
- Get swagger working.


Unique to C#
---------
### Namespace
In C#, a namespace is a way to organize and group related code elements, such as classes, structs, interfaces, enums, and delegates. Namespaces provide a hierarchical organization for your code, helping to prevent naming conflicts between different parts of your application and improving code readability and maintainability. It's considered good practice to utilize namespaces in C#.

<href>https://www.csharptutorial.net/csharp-tutorial/csharp-namespaces/#:~:text=C%23%20namespace%20best%20practices&text=Use%20meaningful%20and%20descriptive%20namespace,only%20for%20frequently%20used%20namespaces.</href>

### solution file
Not having a .sln (solution) file is perfectly fine, especially if you have a simple project with just one .NET Core project in it. The .sln file is used to manage multiple projects within a single solution


appsettings.json is updated for database connection by taking credentials from docker-compose.yml for devcontainer.

command for logging into database
sqlcmd -S db -U SA -P P@ssw0rd


noted dotnet packages installed ontop
-------------------------------------
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Swashbuckle.AspNetCore
