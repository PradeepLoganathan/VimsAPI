namespace VimsAPI;

internal static class CarsApi
{
    public static RouteGroupBuilder MapCarsEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("", () => Results.Ok("Get all cars"));
        group.MapGet("{id}", (int id) => Results.Ok($"Get car with ID: {id}"));
        group.MapPost("", () => Results.Ok("Create a new car"));
        return group;
    }
}