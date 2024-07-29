using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public  class ToDo
    {
        public List<Task>Tasks = new List<Task>();


        public void AddTask(string description)
        {
            Tasks.Add(new Task(description));
        }

        public void RemoveTask(int index)
        {
            if(index>=0 && index < Tasks.Count)
            {
               Tasks.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("There is no task at this index.");
            }
        }
        public void MarkAsFinished(int index)
        {
            if(index>=0 && index < Tasks.Count)
            {
                Tasks[index].IsFinished = true;
            }
            else
            {
                Console.WriteLine("There is no task at this index.");
            }
        }
        public void DisplayAllTasks()
        {
            for(int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Tasks[i]}");
            }
        }
    }
}
