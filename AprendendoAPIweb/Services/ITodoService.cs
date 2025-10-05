using AprendendoAPIweb.Models;

namespace AprendendoAPIweb.Services
{
    public interface ITodoService
    {
        List<Todo> GetAll();
        Todo? GetById(int id);
        Todo Add(Todo newTodo);
    }
}
