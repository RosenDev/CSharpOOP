using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InherterenceExercise
{
    class Student:Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length<5||value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                if (!value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nFaculty number: {FacultyNumber}";
        }

        public Student(string firstName, string lastName,string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
    }
}
