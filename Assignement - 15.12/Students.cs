using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement___15._12
{
   public class Students
    {
        //fields
        private string firstName;
        private string lastName;
        private string studentNumber;
        private float averrageScore;

        //constructors 
        public Students() { }
        public Students (string firstName, string lastName, string studentNumber, float averrageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averrageScore = averrageScore;
        }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string StudentNumber { get { return this.studentNumber; } set { this.studentNumber = value; } }
        
        public float AverrageScore 
        { get { return this.averrageScore; } set { this.averrageScore = value; } }

    }
}
