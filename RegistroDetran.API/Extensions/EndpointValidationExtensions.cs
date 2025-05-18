using FluentValidation;

namespace RegistroDetran.API.Extensions
{
    public static class EndpointValidationExtensions
    {
        public static async Task<IResult> ValidateAndHandle<T>(
            this T model,
            IValidator<T> validator,
            Func<T, Task<IResult>> handler)
        {
            var result = await validator.ValidateAsync(model);
            if (!result.IsValid)
            {
                var errors = result.Errors
                    .GroupBy(e => e.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(e => e.ErrorMessage).ToArray());

                return Results.ValidationProblem(errors);
            }

            return await handler(model);
        }
    }
}
