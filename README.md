# Simple Shop
This project is an example project using SOLID principles and Clean architecture.
Its is used to showcase my understanding and skills in developing .Net project and React project.

There's Swagger endpoint that can be view at [https://localhost:5001/swagger](https://localhost:5001/swagger). When the dot net application is run.

## Technologies
* NET Core 3.1
* ASP.NET Core 3.1
* Entity Framework
* C#
* React
* Axios
* Bootstrap

## Practices
* Clean Code
* SOLID Principles
* Separation of Concerns

## Run

### Steps

1. Open directory **web-client** in command line and execute **yarn** and **yarn start**.
2. Open <[http://localhost:3000](http://localhost:3000)> in browser.
3. Open a command prompt in the **src\SimpleShop.Web** directory and execute the following commands:
```
dotnet restore
dotnet tool restore
dotnet ef database update -c appdbcontext -p ../SimpleShop.Infrastructure/SimpleShop.Infrastructure.csproj -s SimpleShop.Web.csproj
dotnet ef database update -c appidentitydbcontext -p ../SimpleShop.Infrastructure/SimpleShop.Infrastructure.csproj -s SimpleShop.Web.csproj
dotnet run
```
These commands will create two separate databases, one for the product data and one for the app's user credentials and identity data. 
It will then run the application.
4. Open <[https://localhost:5001](https://localhost:5001)> in browser for back office application. You can login using **admin** or **manager** user. Both user password is **password**.
