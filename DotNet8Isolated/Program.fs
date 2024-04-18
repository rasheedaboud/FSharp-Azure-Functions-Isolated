open Microsoft.Extensions.Hosting

HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .Build()
    .Run()
