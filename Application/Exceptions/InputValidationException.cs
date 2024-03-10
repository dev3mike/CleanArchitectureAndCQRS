using Domain.Exceptions.Base;

namespace Application.Exceptions;

public sealed class InputValidationException : BadRequestException
{
    private const string ExceptionMessage = "Validation errors occurred";

    public InputValidationException(Dictionary<string, string[]> errors)
        : base(ExceptionMessage) =>
        Errors = errors;

    public Dictionary<string, string[]> Errors { get; }
}