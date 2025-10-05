
using AprendendoAPIweb.Models;
using AprendendoAPIweb.Services;

namespace AprendendoAPIweb.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<Todo> _todos = new List<Todo>
        {
            new(1, "Walk the dog"),
           new(2, "Do the dishes"),
            new(3, "Do the laundry"),
            new(4, "Clean the bathroom"),
            new(5, "Clean the car")
        };

        private int _nextId = 6;

        public List<Todo> GetAll() => _todos;
        public Todo? GetById(int id) => _todos.FirstOrDefault(t => t.Id == id);

        public Todo Add(Todo newTodo)
        {
            var todoComId = newTodo with { Id = _nextId++ };
            _todos.Add(todoComId);
            return todoComId;
        }
    }
}
