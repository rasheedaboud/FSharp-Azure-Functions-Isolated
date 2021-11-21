namespace My.Function

open Microsoft.Azure.Functions.Worker
open Microsoft.Extensions.Logging
open Microsoft.Azure.Functions.Worker.Http
open System.Net

type Execute(logger: ILogger<Execute>) =
    
    [<Function("Execute")>]        
    member _.Run([<HttpTrigger()>]  req:HttpRequestData, executionContext:FunctionContext) =
        task {
            logger.LogInformation($"Hello at {System.DateTime.UtcNow} from an Azure function using F# on .NET 5.")
            let response = req.CreateResponse(HttpStatusCode.OK)
            do! response.WriteStringAsync("Hello World")
            return response
        }
        

