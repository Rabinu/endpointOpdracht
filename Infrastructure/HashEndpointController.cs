using Microsoft.AspNetCore.Mvc;
using HashEndpoint.Domain;

namespace HashEndpoint.Infrastructure;
// Beetje automatisch van mij dat ik in DDD mappen structuur werk maar dit had ik dus ook in een mvc structuur kunnen gieten en een Controller en Model folder voor aan kunnen maken

[ApiController]
public class HashEndpointController : ControllerBase
{
    [Route("api/create-hash")] 
    [HttpPost]
    public ActionResult CreateHash(string input)
    {
        var generatedHash = Hash.GenerateHash(input);

        return Ok(generatedHash);
    }
}