namespace FluentValidationExample.Resources;

public record UserResource(
    string Username,
    string Password,
    string FirstName,
    string LastName,
    string Email,
    int Age);