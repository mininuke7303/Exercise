using SharedLibrary;
using System;
using System.Collections.Generic;

namespace TodoApp.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            ITodoRepositoryInMemory _repository = new TodoRepositoryInMemory();

            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();

            foreach (var  item in todos) {
                Console.WriteLine($"{item.Id} - {item.Title}({item.IsDone})");
            }

            Todo todo = new Todo { Title = "Database", IsDone = true };
            _repository.Add(todo);

            todos = _repository.GetAll();
            foreach (var item in todos) {
                Console.WriteLine($"{item.Id} - {item.Title}({item.IsDone})");
            }
        }
    }
}
