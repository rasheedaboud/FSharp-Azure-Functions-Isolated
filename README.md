# Example Azure Function using F# on .NET 8

This repo shows a minimal example of how to write an Azure function using F# and run it on .NET 8 isolated mode.

It should be as simple as cloning the repo and running the function app.

Built using Microsoft Visual Studio Community 2022 (64-bit) Version 17.9 and Dotnet 8 version 8.0.204.

### ASP.NET Core Integration

The Azure Functions team added the ability to integrate function with asp.net core HttpRequest and response types. I personally prefer this approach to using the HttpRequestData. 

Head over [here]("https://learn.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-process-guide?tabs=windows#aspnet-core-integration") to learn more about how to enable ASP.NET Core integration for HTTP requests in your own projects.