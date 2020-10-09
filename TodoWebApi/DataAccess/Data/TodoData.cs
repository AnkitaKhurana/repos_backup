using DataAccess.Mapper;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoData.Entities;

namespace DataAccess.Data
{
    public class TodoData
    {
        private TodoContext db = new TodoContext();

        public bool AddTodo(TodoDTO todo, string user)
        {
            try
            {
                var userfound = db.Users.Where(x => x.UserName == user).FirstOrDefault();
                if (userfound != null)
                {
                    Todo todoDB = TodoMapper.ToDB(todo);
                    todoDB.Id = Guid.NewGuid();
                    todoDB.DateGenerated = DateTime.Now;
                    todoDB.DateUpdated = todoDB.DateGenerated;
                    todoDB.Status = 1;
                    todoDB.UserId = userfound.Id;
                    db.Todos.Add(todoDB);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TodoDTO> GetTodos(string user)
        {
            try
            {
                var userfound = db.Users.Where(x => x.UserName == user).FirstOrDefault();
                if (userfound != null)
                {
                    var todos = db.Todos.Where(x => x.User.UserName == user);
                    List<TodoDTO> todosDTO = new List<TodoDTO>();
                    foreach (var todo in todos)
                    {
                        TodoDTO todoDTO = new TodoDTO()
                        {
                            Message = todo.Message,
                            Id = todo.Id,
                            DateGenerated = todo.DateGenerated,
                            DateUpdated = todo.DateUpdated,
                            FinishDate = todo.FinishDate,
                            Status = todo.Status,
                            UserId = todo.UserId

                        };
                        todosDTO.Add(todoDTO);
                    }
                    return todosDTO;
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }

        }

        public bool EditTodo(Guid todoId, string user, string message)
        {
            try
            {
                var userfound = db.Users.Where(x => x.UserName == user).FirstOrDefault();
                if (userfound != null)
                {
                    var todoFound = db.Todos.Where(x => x.Id == todoId).FirstOrDefault();
                    todoFound.Message = message;
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
