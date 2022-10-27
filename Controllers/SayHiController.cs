//Reed Goodwin
//10-25-2022
//Say Hi!
//This program takes ur name a greets you !
//Peer Review: Jessie Lamzon
//Code runs well and without any errors!  Good job!

using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_SayHelloAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHiController : ControllerBase
{
    [HttpGet]
    [Route("sayhello/{name}")]
    public string gayballs(string name){
        
    return $"whats up {name}! Its good to meet you ! :)";
}
}
