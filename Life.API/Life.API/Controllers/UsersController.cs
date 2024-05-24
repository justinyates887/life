using Life.API.Interfaces;
using Life.API.Objects;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IRepository<User> _userRepository;

    public UsersController(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return Ok(await _userRepository.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(ObjectId id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser(User user)
    {
        await _userRepository.CreateAsync(user);
        return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(string id, [FromBody] UserUpdateDto userDto)
    {
        if (string.IsNullOrEmpty(id))
        {
            return BadRequest("Id parameter is required.");
        }

        var objectId = ObjectId.Parse(id);

        var user = await _userRepository.GetByIdAsync(objectId);
        if (user == null)
        {
            return NotFound();
        }

        // Update user properties if provided in the DTO
        if (!string.IsNullOrEmpty(userDto.BudgetId))
        {
            user.BudgetId = userDto.BudgetId;
        }

        if (!string.IsNullOrEmpty(userDto.UserEmail))
        {
            user.UserEmail = userDto.UserEmail;
        }

        if (!string.IsNullOrEmpty(userDto.PasswordHash))
        {
            user.PasswordHash = userDto.PasswordHash;
        }

        // Update the user object in the repository
        var result = await _userRepository.UpdateAsync(objectId, user);
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }



    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(ObjectId id)
    {
        var result = await _userRepository.DeleteAsync(id);
        if (!result)
        {
            return NotFound();
        }
        return NoContent();
    }
}
