# WebLibrary
Livraria WEB HBSIS
Versäo do .NET CORE SDK 2.1.402
    • ASP.NET Core Runtime 2.1.4

# Para baixar as dependências, utilizei o comando?
dotnet restore

# Para compilar o projeto, utilizei?
dotnet build

# Para executar o programa, utilizei o comando
dotnet run

# Para criar uma solution
dotnet new sln --name DDD.Build.Solution

# Para adicionar um projeto na solution
dotnet sln add src/StoredOfBuild.Domain/StoredOfBuild.Domain.csproj

# Para criar o project mvc
dotnet new mvc

# Para criar o projeto Class Library
dotnet new classlib

dotnet new sln --name DDD.Build
dotnet new webapi
dotnet new classlib
dotnet sln add .\DDD.API\
dotnet sln add .\DDD.Domain\
dotnet sln add .\DDD.Infra\

# Para adicionar projects em outros projects 
dotnet add reference lib1/lib1.csproj lib2/lib2.csproj


dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools


dotnet add package Microsoft.AspNetCore.App


dotnet add package Unity
dotnet add package Microsoft.AspNet.WebApi.Core



# Atualiza Migrations com Banco de Dados
dotnet ef database update

# Atualiza Migrations com Banco de Dados
dotnet ef database update


dotnet new webapi

dotnet add package Microsoft.AspNet.WebApi.Owin
dotnet add package Microsoft.Owin.Host.SystemWeb
dotnet add package Microsoft.Owin.Security.OAuth
dotnet add package Microsoft.Owin.Cors


dotnet add package Swashbuckle




yarn init
yarn add bootstrap jquery jquery-validation jquery-validation-unobtrusive angular
yarn add gulp gulp-concat gulp-cssmin gulp-uncss browser-sync
yarn gulp css