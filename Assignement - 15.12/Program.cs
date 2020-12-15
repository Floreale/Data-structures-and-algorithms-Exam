using System;
using System.Collections;
using System.Collections.Generic; 

namespace Assignement___15._12
{
  public  class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Students> students = new LinkedList<Students>();

            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Menu : " +
                    "\n 1 : Populate with sample data " +
                    "\n 2 : Add a student " +
                    "\n 3 : Get an element " +
                    "\n 4 : Remove a chosen student " +
                    "\n 5 : Remove the first student " +
                    "\n 6 : Remove the last student  " +
                    "\n 7 : Display all students  "



                                   + "\n\n Choose what you want to do  : ");

                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:

                        CustomDataList.SampleDataBase(students);

                        break;

                    case 2:
                        
                        CustomDataList.AddElement(students);
                        break;

                    case 3:
                        
                        Console.WriteLine("Which Student do you want to display ? (enter a number starting from 0)");
                        int index = int.Parse(Console.ReadLine());
                        CustomDataList.getElement(index, students); 
                        break;

                    case 4:
                        
                        Console.WriteLine("Which Student do you want to remove from the list ? (enter a number starting from 0)");
                        int index4 = int.Parse(Console.ReadLine());
                        CustomDataList.RemoveStudent(index4, students);
                        break;

                    case 5:
                        CustomDataList.removeTheFirst(students);
                        break;

                    case 6:
                        CustomDataList.removeTheLast(students);
                        break;

                    case 7:
                        CustomDataList.DisplayList(students);

                        break;

                }
                Console.WriteLine("\nPress enter or exit ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
           
            Console.ReadKey();
        }
        


    }
}
