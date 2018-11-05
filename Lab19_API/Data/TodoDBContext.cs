using Lab19_API.Controllers;
using Lab19_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19_API.Data
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        public static implicit operator TodoDBContext(TodoController v)
        {
            throw new NotImplementedException();
        }
    }
}
