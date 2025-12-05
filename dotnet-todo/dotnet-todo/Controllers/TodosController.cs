using Microsoft.AspNetCore.Mvc;
using dotnet_todo.Models;

namespace dotnet_todo.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Overview()
        {
            var todos = new List<Models.Todos>
            {
                new Todos { Id = 1, Title = "Buy groceries", Description = "Milk, Bread, Eggs", IsCompleted = false },
                new Todos { Id = 2, Title = "Walk the dog", Description = "Evening walk in the park", IsCompleted = true },
                new Todos { Id = 3, Title = "Read a book", Description = "Finish reading 'The Great Gatsby'", IsCompleted = false }
            };
            return View(todos);
        }
    }
}
