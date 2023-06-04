using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ToDo_App
{
  static  class TaskManager
    {
        static ArrayList arraylist = new ArrayList(); 
     public static void AddTask(Task n)
        {
            arraylist.Add(n);
        }
     public  static  void DeleteTask(Task n)
        {
            arraylist.Remove(n);
        }
       public static int SearchForTask(Task n)
        {
            return arraylist.IndexOf(n); 
        }
    }
}
