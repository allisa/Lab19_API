using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19_API.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
