namespace My.Function

open Microsoft.Azure.Functions.Worker
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc

type Execute(logger: ILogger<Execute>) =

    [<Function(nameof Execute)>]
    member _.Run
        (
            [<HttpTrigger(AuthLevel = AuthorizationLevel.Anonymous, Methods = [| "GET" |], Route = "execute")>] req: HttpRequest,
            executionContext: FunctionContext,
            [<FromQuery>] name: string
        ) =
        task {
            logger.LogInformation($"Hello at {System.DateTime.UtcNow} from an Azure function using F# on .NET 8.")

            let response =
                if System.String.IsNullOrEmpty(name) then
                    "Hello from F# and dotnet 8!"
                else
                    $"Hello {name}! F# is amazing!"

            return OkObjectResult(response)
        }
