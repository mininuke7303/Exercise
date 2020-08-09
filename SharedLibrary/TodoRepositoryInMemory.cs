﻿using System.Collections.Generic;
using System.Linq;

namespace SharedLibrary {
    // 인-메모리 데이터베이스 사용 영역
    public class TodoRepositoryInMemory : ITodoRepositoryInMemory {


        private static List<Todo> _todos = new List<Todo>();
        public TodoRepositoryInMemory() {
            _todos = new List<Todo> {
                new Todo {Id = 1, Title = "ASP.NET 학습", IsDone = false},
                new Todo {Id = 2, Title = "Blazor 학습", IsDone = false},
                new Todo {Id = 3, Title = "C# 학습", IsDone = true},
            };
        }


        public void Add(Todo model) {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll() {
            return _todos.ToList();
        }
    }


}
