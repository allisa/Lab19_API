using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19_API.Models
{
    public class TodoList
    {
        public int ID { get; set; }
        public string ListTitle { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
