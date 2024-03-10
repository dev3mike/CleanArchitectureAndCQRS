using Application.CommandAndQueries.Users.Commands.CreateUser;
using Application.CommandAndQueries.Users.Queries.GetUserById;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public sealed class UsersControllers : ApiBaseController
{
    /// <summary>
    /// Get the user with the specified identifier, if it exists.
    /// </summary>
    /// <param name="userId">The user identifier.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The user with the specified identifier, if it exists.</returns>
    [HttpGet("{userId:guid}")]
    [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUser(Guid userId, CancellationToken cancellationToken)
    {
        var query = new GetUserByIdQuery(userId);

        var user = await Sender?.Send(query, cancellationToken)!;

        return Ok(user);
    }
    
    
    /// <summary>
    /// Creates a new user based on the specified request.
    /// </summary>
    /// <param name="request">The create user request.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The identifier of the newly created user.</returns>
    [HttpPost]
    [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateUser(
        [FromBody] CreateUserRequest request,
        CancellationToken cancellationToken)
    {
        var command = request.Adapt<CreateUserRequest>();

        var userId = await Sender?.Send(command, cancellationToken)!;

        return CreatedAtAction(nameof(GetUser), new { userId }, userId);
    }
}