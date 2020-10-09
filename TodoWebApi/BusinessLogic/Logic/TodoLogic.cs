﻿using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using TD = DataAccess.Data.TodoData;


namespace BusinessLogic.Logic
{
    public class TodoLogic
    {
        private TD todoData = new TD();

        public List<TodoDTO> GetTodos (string user)
        {
            try
            {
                return todoData.GetTodos(user);
            }
            catch
            {
                return null;
            }

        }

        public bool AddNewTodo(TodoDTO todoDTO, string userId)
        {
            try
            {
                if(todoData.AddTodo(todoDTO, userId))
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool EditNewTodo(Guid todoid, string userId, string message)
        {
            try
            {
                if (todoData.EditTodo(todoid, userId, message))
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
