using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Shared
{
    public class Todo
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public bool IsComplete { get; set; }
    }
}
