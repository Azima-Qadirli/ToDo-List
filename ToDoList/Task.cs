using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsFinished { get; set; }

        public Task(string description)
        {
            Description = description;
            IsFinished = false;
        }
        public override string ToString()
        {
            return $"Description: {Description} {(IsFinished ? "[Finished]" : "[Waiting]")}"; //1st part is if part, second part is else part
        }
    }
}
