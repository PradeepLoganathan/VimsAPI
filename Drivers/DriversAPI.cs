namespace VimsAPI;

internal static class DriversApi
{
    public static RouteGroupBuilder MapDriversEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("", () => Results.Ok("Get all drivers"));
        group.MapGet("{id}", (int id) => Results.Ok($"Get driver with ID: {id}"));
        group.MapPost("", () => Results.Ok("Create a new driver"));
        return group;
    }
}