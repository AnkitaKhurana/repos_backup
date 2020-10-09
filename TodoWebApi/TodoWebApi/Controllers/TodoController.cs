﻿using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoWebApi.Mapper;
using TodoWebApi.Models;

namespace TodoWebApi.Controllers
{
    public class TodoController : ApiController
    {
        private BusinessLogic.Logic.TodoLogic todoLogic = new BusinessLogic.Logic.TodoLogic();

        [Authorize]
        [HttpPost]
        public HttpResponseMessage Add(Todo todo)
        {
            try
            {
                TodoDTO todoDTO = TodoMapper.ToDTO(todo);
                var todoSaved = todoLogic.AddNewTodo(todoDTO, User.Identity.Name);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, todoSaved);
                if (todoSaved == false)
                {
                    response.StatusCode = HttpStatusCode.OK;
                }
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                return response;
            }
        }

        [Authorize]
        public HttpResponseMessage GetTodos()
        {
            try
            {
                var todos = todoLogic.GetTodos(User.Identity.Name);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
               
                    response.StatusCode = HttpStatusCode.OK;
                
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                return response;
            }
        }

        [Authorize]
        [HttpPost]
        public HttpResponseMessage Edit(Todo todo)
        {
            try
            {
                var todoSaved = todoLogic.EditNewTodo(todo.Id, User.Identity.Name, todo.Message);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, todoSaved);
                if (todoSaved == false)
                {
                    response.StatusCode = HttpStatusCode.OK;
                }
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                return response;
            }
        }
    }

}
