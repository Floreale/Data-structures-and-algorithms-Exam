using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Assignement___15._12
{
    public class CustomDataList
    {
        public CustomDataList()
        {

        }


        public static void SampleDataBase (LinkedList<Students> students)
        {
            string firstName_1 = "Floréale";
            string lastName_1 = "Barraud";
            string studentNumber_1 = "L-202";
            float averrageScore_1 = 67;
            Students  Floréale = new Students(firstName_1, lastName_1, studentNumber_1, averrageScore_1);
            students.AddFirst(Floréale);

            string firstName_2 = "Capucine";
            string lastName_2 = "Baud-Berthier";
            string studentNumber_2 = "L-203";
            float averrageScore_2 = 75;
            Students Capucine = new Students(firstName_2, lastName_2, studentNumber_2, averrageScore_2);
            students.AddFirst(Capucine);

            string firstName_3 = "Ines";
            string lastName_3 = "Meunier";
            string studentNumber_3 = "L-205";
            float averrageScore_3 = 98;
            Students Ines = new Students(firstName_3, lastName_3, studentNumber_3, averrageScore_3);
            students.AddFirst(Ines);

            string firstName_4 = "Jeanne";
            string lastName_4 = "Lonjon";
            string studentNumber_4 = "L-439";
            float averrageScore_4 = 69;
            Students Jeanne = new Students(firstName_4, lastName_4, studentNumber_4, averrageScore_4);
            students.AddFirst(Jeanne);

        }

        public static void AddElement (LinkedList<Students> students)
        {
            Console.WriteLine("Enter the First Name of the student you want to ad :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of the student you want to ad :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter his/her student number :");
            string studentNumber = Console.ReadLine();
            Console.WriteLine("Enter his/her averrage score :");
            float averrageScore = float.Parse(Console.ReadLine());
            Students newStudent = new Students(firstName, lastName, studentNumber, averrageScore);
            students.AddFirst(newStudent);

        }

        public static void DisplayList (LinkedList<Students> students)
        {
            Console.WriteLine(" The list of students is composed of this student : ");
            foreach (Students student in students)
            {
                Console.WriteLine("\n\nStudent Name : " + student.FirstName + " " + student.LastName + "\nStudent number : " + student.StudentNumber + "\nstudent averrage score : " + student.AverrageScore + "\n\n" );
            }
            Console.WriteLine("");
        }

        public static void getElement (int index, LinkedList<Students>students)
        {
            Students[] tab = new Students[students.Count];

            students.CopyTo(tab, 0); 

            for (int i = 0; i < tab.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine($"Student name : {index} :\n{ tab[i].FirstName} { tab[i].LastName},  Student number : {tab[i].StudentNumber},  Averrage Score :{tab[i].AverrageScore}");
                }
            }
        }

       public static void RemoveStudent (int index, LinkedList<Students>students)
        {
            Students[] tab = new Students[students.Count];

            students.CopyTo(tab, 0);

            Students temp =tab[index];
            students.Remove(temp);
            Console.WriteLine(  temp.FirstName +" " + temp.LastName + " has been removed from the list");
           
        }

        public static void removeTheLast(LinkedList<Students> students)
        {
            students.RemoveLast();
        }

        public static void removeTheFirst (LinkedList<Students>students)
        {
            students.RemoveFirst();
        }
        
    }
}
