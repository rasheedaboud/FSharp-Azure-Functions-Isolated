open Microsoft.Extensions.Hosting

HostBuilder()
    .ConfigureFunctionsWebApplication()
    .Build()
    .RunAsync()
|> Async.AwaitTask
|> Async.RunSynchronously
