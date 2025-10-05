using AprendendoAPIweb.Services;
namespace AprendendoAPIweb.Endpoints
{
    public static class TodoEndpoints
    {
        public static void MapTodoEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/todos");
            group.MapGet("/", (ITodoService service) =>
            {
                return Results.Ok(service.GetAll());
            });

            group.MapGet("/{id}", (int id, ITodoService service) =>
            {
                var todo = service.GetById(id);
                return todo is null ? Results.NotFound() : Results.Ok(todo);
            });

            group.MapPost("/", (Todo todo, ITodoService service) =>
            {
                var novoTodo = service.Add(todo);
                return Results.Created($"/api/todos/{novoTodo.Id}", novoTodo);
            });

        }
    }
}
