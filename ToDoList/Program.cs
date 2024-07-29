using ToDoList;

class Program
{
    static void Main(string[] args)
    {
        ToDo toDo = new ToDo();
        bool executing = true;

        while (executing)
        {
            Console.WriteLine("ToDo Application");
            Console.WriteLine("1.Add task.");
            Console.WriteLine("2.Remove task.");
            Console.WriteLine("3.Mark task as finished.");
            Console.WriteLine("4.Display all tasks.");
            Console.WriteLine("5.Exit.");
            Console.WriteLine("Choose your choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter your task's description:");
                    string description = Console.ReadLine();
                    toDo.AddTask(description);
                break;

                case "2":
                    Console.WriteLine("Enter your task number to remove:");
                    if(int .TryParse(Console.ReadLine(), out int removeIndex))
                    {
                        toDo.RemoveTask(removeIndex-1);
                    }
                    else
                    {
                        Console.WriteLine("It is incorrect index.");
                    }
                break;
                case "3":
                    Console.WriteLine("Enter your task to finish.");
                    if(int.TryParse(Console.ReadLine(),out int completeIndex))
                    {
                        toDo.MarkAsFinished(completeIndex-1);
                    }
                    else
                    {
                        Console.WriteLine("It is incorrect index.");
                    }
                break;
                case "4":
                    toDo.DisplayAllTasks();       
                break;
                case "5":
                    executing = true;
                break;
                default:
                    Console.WriteLine("Sorry, but you entered incorrect choice.Try again.");
                    break;
            }
        }
    }
}