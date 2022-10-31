using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public class FootballPlayer 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {

        }
        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException("A name is required");
            if (Name.Length <= 2)
                throw new ArgumentException("Name must contain 2 or more letters");
        }

        public void ValidateAge()
        {
            if (Age < 2)
                throw new ArgumentException("Sorry Mate you have to  be at least 2 years to play :(");
            

        }

        public void ValidateShirtNum()
        {
            if (ShirtNumber < 2 || ShirtNumber > 99)
                throw new ArgumentException("The shirtnumber has to be between 1 and 99");

        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNum();
        }


    }
}