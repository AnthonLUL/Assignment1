using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public class FootballPlayer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {

        }
        public string TestNameConstraint(string Name)
        {
            int NameLength = Name.Length;

            if (NameLength >= 2 && Name.All(Char.IsLetter))
            {
                return Name;
            }
            else
            {
                throw new ArgumentException("Name must contain 2 or more letters");
            }
        }

        public int TestAgeConstraints(int age, int obj)
        {
            if (age > 1)
            {
                return age;
            }
            else
            {
                throw new ArgumentException("Sorry Mate you have to  be at least 2 years to play :(");
            }

        }

        public int TestShirtNumber(int shirtNum)
        {
            if (shirtNum >= 1 && shirtNum <= 99)
            {
                return shirtNum;
            }
            else
            {
                throw new ArgumentException("The shirtnumber has to be between 1 and 99");
            }

        }


    }
}