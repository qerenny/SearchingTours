using Microsoft.AspNetCore.Mvc;
using SearchingTours.Application.Contracts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Presentation.Http.Requests;
using SearchingTours.Presentation.Http.Responses;

namespace SearchingTours.Presentation.Http.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public ActionResult<UserEntity> Get(Guid id)
    {
        UserEntity? user = _userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost]
    public ActionResult<UserPostResponse> Post([FromBody] UserPost data)
    {
        try
        {
            UserEntity createdUser = _userService.Create(data.Username, data.Phone, data.Email, data.Password, data.City);
            return CreatedAtAction(nameof(Get), new { id = createdUser.Id }, createdUser);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while creating the user." + ex);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<UserEntity> Update(Guid id, [FromBody] Dictionary<string, string> data)
    {
        try
        {
            UserEntity? updatedUser = _userService.Update(id, data);
            return Ok(updatedUser);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        bool result = _userService.Delete(id);
        if (result)
        {
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }
}