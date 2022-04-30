using FluentValidationExample.Resources;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    [HttpPost]
    public ActionResult<UserResource> Create([FromBody] UserResource user)
    {
        return Ok(user);
    }
}