namespace f__web_app.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

open UniversityDomain

[<ApiController>]
[<Route("[controller]")>]
type StudentsController (logger : ILogger<StudentsController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        let students = new ResizeArray<Student>()
        students.Add 
        students
