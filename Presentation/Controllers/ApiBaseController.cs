using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiBaseController : ControllerBase
{
    private ISender? _sender;
        
    /// <summary>
    /// Gets the sender.
    /// </summary>
    protected ISender? Sender => _sender ??= HttpContext.RequestServices.GetService<ISender>();
}