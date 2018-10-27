using System;
using System.Collections.Generic;
using System.Text;

namespace InherterenceExercise
{
    class Human
    {
        private string firstName;
        private string lastName;

      protected string FirstName
        {
            get => firstName;
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");   
                }

                if (value.Length<=3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }

                firstName = value;
            }
        }

        protected string LastName
        {
            get => lastName;
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }

                if (value.Length <=2)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }

                lastName = value;
            }
        }

       protected Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
