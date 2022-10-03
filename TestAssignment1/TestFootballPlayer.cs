using Assignment1;
using System.ComponentModel.DataAnnotations;

namespace TestAssignment1
{
    [TestClass]
    public class TestFootballPlayer
    {
        [DataTestMethod]
        [DataRow("Anthon")]
        public void TestNameContainingTwoOrMoreCharacters(string name)
        {
            //arrange
            string nameToCheck = "Anthon";
            string expectedResult = "Anthon";

            Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();

            //act
            string actualResult = footballPlayer.TestNameConstraint(nameToCheck);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("A")]
        public void TestNameContainingOneCharacter(string name)
        {
            //arrange
            string nameToCheck = "A";
            string expectedResult = "A";

            Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();
            try
            {
                footballPlayer.TestNameConstraint(nameToCheck);
            }
            catch(System.ArgumentException)
            {
                return;
            }

            //act
            string actualResult = footballPlayer.TestNameConstraint(nameToCheck);

            //assert
            Assert.Fail(actualResult);
        }

        [DataTestMethod]
        [DataRow("A1")]
        public void TestNameContainingOneNumberOneLetter(string name)
        {
            //arrange
            string nameToCheck = "A1";
            string expectedResult = "A1";

            Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();
            try
            {
                footballPlayer.TestNameConstraint(nameToCheck);
            }
            catch (System.ArgumentException)
            {
                return;
            }

            //act
            string actualResult = footballPlayer.TestNameConstraint(nameToCheck);

            //assert
            Assert.Fail(actualResult);
        }

        [DataTestMethod]
        [DataRow(3)]
        public void TestAge(int age)
        {
            //arrange
            int ageToCheck = 3;
            int expectedResult = 3;

            Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();

            //act
            int actualResult = footballPlayer.TestAgeConstraints(age, expectedResult);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(8)]
        public void TestShirtNumber(int shirtNumber)
        {
            //arrange
            int ageToCheck = 8;
            int expectedResult = 8;

            Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();

            //act
            int actualResult = footballPlayer.TestShirtNumber(shirtNumber);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //[DataTestMethod]
        //[DataRow("1")]
        //public void TestAgeContainingLetter(int age)
        //{
        //    //arrange
        //    string AgeToCheck = Convert.ToString(1);
        //    int expectedResult = 1;

        //    Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();
        //    try
        //    {
        //        footballPlayer.TestAgeConstraints(Convert.ToInt32(AgeToCheck), expectedResult);
        //    }
        //    catch (System.ArgumentException)
        //    {
        //        return;
        //    }

        //    //act
        //    int actualResult = footballPlayer.TestAgeConstraints(Convert.ToInt32(AgeToCheck), expectedResult);

        //    //assert
        //    Assert.Fail();
        //}
    }
}

