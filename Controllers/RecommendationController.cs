using Microsoft.AspNetCore.Mvc;
using ReccAlgWebApi.Contracts;

namespace ReccAlgWebApi.Controllers;

[ApiController]
[Route("controller")]
public class RecommendationController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRequest request)
    {
        return Ok();
    }
}