using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Task t = new Task("Noor");
            Task t1 = new Task("go to university");
            Task t2 = new Task("buy things");
           
            TaskManager.AddTask(t);
            TaskManager.AddTask(t1);
            TaskManager.AddTask(t2);
            
        }
    }
}
